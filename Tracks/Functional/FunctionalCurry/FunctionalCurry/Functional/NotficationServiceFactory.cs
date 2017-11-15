using FunctionalCurry.Common;
using System;

namespace FunctionalCurry.Functional
{
    public  class NotficationServiceFactory
    {


        public  Func<UserInfo, Outcome> GetNotificationService(string serviceName)
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

        
    }
}
