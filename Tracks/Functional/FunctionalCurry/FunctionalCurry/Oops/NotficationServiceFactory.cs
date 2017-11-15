using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCurry.Oops
{
    public class NotficationServiceFactory
    {

        public INotificationService GetNotificationService(string serviceName )
        {
            INotificationService service = null;
             switch (serviceName)
            {
                case "Email":
                case "email":
                    service = GetEmailNotificationService();
                    break;
                case "sms":
                case "SMS":
                    service = GetSmsNotificationService();
                    break;
                default:
                    break;
            }
            return service;
        }

        private INotificationService GetSmsNotificationService()
        {
            return new SmsNotificationService(ConfigurationManager.AppSettings["Twilio:ACCOUNT_SID"], ConfigurationManager.AppSettings["Twilio:AUTH_TOKEN"]);
        }

        private INotificationService GetEmailNotificationService()
        {
            var emailDetailsProvider = new EmailDetailsProvider();

            return new EmailNotificationService(emailDetailsProvider,
                ConfigurationManager.AppSettings["smtp:server"],
                int.Parse(ConfigurationManager.AppSettings["smtp:port"]),
                ConfigurationManager.AppSettings["smtp:userName"],
                ConfigurationManager.AppSettings["smtp:password"],
                ConfigurationManager.AppSettings["smtp:senderEmailId"]);
        }

        
    }
}
