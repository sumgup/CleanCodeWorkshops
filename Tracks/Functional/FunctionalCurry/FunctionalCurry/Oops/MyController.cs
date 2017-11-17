using FunctionalCurry.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCurry.Oops
{
    public class MyController
    {
        private NotificationServiceFactory notficationServiceFactory;
        private IUserProvider userProvider;

        public MyController(IUserProvider userProvider, NotificationServiceFactory notficationServiceFactory )
        {
            this.notficationServiceFactory = notficationServiceFactory;
            this.userProvider = userProvider;
        }

        public void SendEmailNotication(int userId)
        {
            var emailNotificationService= notficationServiceFactory.GetNotificationService("email");
            var userInfo = userProvider.GetUserById(userId);
            var result = emailNotificationService.SendNotification(userInfo);

            Console.WriteLine(result.IsSuccess ? result.Message : ((result.ErrorMessage != null && result.ErrorMessage.Length > 0) ? string.Join(" , ", result.ErrorMessage) : "Unknown Error"));


        }

        public void SendSmsNotication(int userId)
        {
            var smsNotificationService = notficationServiceFactory.GetNotificationService("sms");
            var userInfo = userProvider.GetUserById(userId);
            var result = smsNotificationService.SendNotification(userInfo);
            Console.WriteLine(result.IsSuccess ? result.Message : ((result.ErrorMessage != null && result.ErrorMessage.Length > 0) ? string.Join(" , ", result.ErrorMessage) : "Unknown Error"));

        }


    }
}
