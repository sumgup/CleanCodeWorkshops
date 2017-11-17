using FunctionalCurry.Common;
using System;
using System.Configuration;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace FunctionalCurry.Functional
{
    public static  class SmsNotificationService
    {

        public static Func<UserInfo, Outcome> GetComposedSmsNotificationService()
        {
            Func<UserInfo, Tuple<string, string>> getSmsDetails = (u) => GetSmsDetails(u);

            Func<Tuple<string, string>> getTwilloServerDetails = () => GetTwilioConfigSetting();

            return (UserInfo userInfo) => SendSMS(userInfo, getSmsDetails, getTwilloServerDetails);
        }


        private static Outcome SendSMS(UserInfo userInfo, Func<UserInfo, Tuple<string, string>> getSmsDetails, Func<Tuple<string, string>> getTwilloServerDetails)
        {
            try
            {
                var twilioCredential = getTwilloServerDetails();
                TwilioClient.Init(twilioCredential.Item1, twilioCredential.Item2);
                var smsDetails = getSmsDetails(userInfo);
                var message = MessageResource.Create(new PhoneNumber(userInfo.PhoneNumber), from: new PhoneNumber(smsDetails.Item1), body: smsDetails.Item2);
                return Outcome.Ok( $"message sent. sentId is {message.Sid}");
            }
            catch (Exception ex)
            {

                return Outcome.Fail( ex.Message);
            }
        }

        private static Tuple<string, string> GetTwilioConfigSetting()
        {
            return new Tuple<string, string>(ConfigurationManager.AppSettings["Twilio:ACCOUNT_SID"], ConfigurationManager.AppSettings["Twilio:AUTH_TOKEN"]);
        }



        private static Tuple<string, string> GetSmsDetails(UserInfo userInfo)
        {
            var messageBody = $"Hello {userInfo.FirstName}, this is test message from clean code";
            var fromNumber = "+919723812403";
            return new Tuple<string, string>(fromNumber, messageBody);
        }
    }
}
