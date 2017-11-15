using FunctionalCurry.Common;
using System;

namespace FunctionalCurry.Functional
{
    public class NotficationServiceFactory
    {


        public Func<UserInfo, Outcome> GetNotificationService(string serviceName)
        {
            return (userInfo) =>
            {
                switch (serviceName)
                {
                    case "Email":
                    case "email":
                        return EmailNotificationService.GetComposedEmailNotificationService()(userInfo);
                    case "sms":
                    case "SMS":
                        return SmsNotificationService.GetComposedSmsNotificationService()(userInfo);
                    default:
                        return null;
                }
            };

        }



        public Func<Func<Tuple<string, int, string, string, string>>, Func<UserInfo, Outcome>> GetCurryStyleNotificationService()
        {
            return EmailNotificationService.GetComposedEmailNotificationServiceByCurryWay();
        }

        public  Func<Tuple<string, int, string, string, string>> GetSmtpDetails() => () => EmailNotificationService.GetSmtpServerDetails();




    }
}
