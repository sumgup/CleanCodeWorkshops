using System;
using FunctionalCurry.Common;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace FunctionalCurry.Oops
{
    public class SmsNotificationService : INotificationService
    {
        private string ACCOUNT_SID;
        private string AUTH_TOKEN;

        public SmsNotificationService(string ACCOUNT_SID , string AUTH_TOKEN)
        {
            this.ACCOUNT_SID = ACCOUNT_SID;
            this.AUTH_TOKEN = AUTH_TOKEN;
        }

        public Outcome SendNotification(UserInfo userInfo)
        {
            try
            {               
                TwilioClient.Init(ACCOUNT_SID, AUTH_TOKEN); ;
                var smsDetails = GetSmsDetaills(userInfo);
                var message = MessageResource.Create(new PhoneNumber(userInfo.PhoneNumber), from: new PhoneNumber(smsDetails.Item1), body: smsDetails.Item2);
                return  Outcome.Ok( $"message sent. sentId is {message.Sid}");
            }
            catch (Exception ex)
            {

                return  Outcome.Fail( ex.Message);
            }
        }

        



        private static Tuple<string, string> GetSmsDetaills(UserInfo userInfo)
        {
            var messageBody = $"Hello {userInfo.FirstName}, this is test message from clean code";
            var fromNumber = "+919723812403";
            return new Tuple<string, string>(fromNumber, messageBody);
        }
    }
}
