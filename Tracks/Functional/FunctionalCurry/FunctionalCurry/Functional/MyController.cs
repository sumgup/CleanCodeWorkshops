using FunctionalCurry.Common;
using System;

namespace FunctionalCurry.Functional
{
    public class MyController
    {

        private NotficationServiceFactory notficationServiceFactory;
        private IUserProvider userProvider;

        public MyController(IUserProvider userProvider, NotficationServiceFactory notficationServiceFactory)
        {
            this.notficationServiceFactory = notficationServiceFactory;
            this.userProvider = userProvider;
        }


        

        public void SendEmailNotication(int userId)
        {
            Console.WriteLine("~~~~ Start SendEmailNotication ~~~~~~");

            var emailNotificationService = notficationServiceFactory.GetNotificationService("email");
            //var userInfo = userProvider.GetUserById(userId);            
            //var result = emailNotificationService(userInfo);

            var result = userProvider
                .GetUserById(userId)
                .SendNotification((u) => emailNotificationService(u));

            //var result =userProvider
            //    .GetUser<UserInfo>(userId)
            //    .SendNotification((u) => emailNotificationService(u));

            Console.WriteLine(result.IsSuccess ? result.Message : ((result.ErrorMessage != null && result.ErrorMessage.Length > 0) ? string.Join(" , ", result.ErrorMessage) : "Unknown Error"));

            Console.WriteLine("~~~~ End SendEmailNotication ~~~~~~");

        }

        public void SendSmsNotication(int userId)
        {
            Console.WriteLine("~~~~ Start SendSmsNotication ~~~~~~");

            var smsNotificationService = notficationServiceFactory.GetNotificationService("sms");
            var userInfo = userProvider.GetUserById(userId);
            var result = smsNotificationService(userInfo);

           // var result = userProvider.GetUserById(userId).SendNotification((u) => smsNotificationService(u));
            Console.WriteLine(result.IsSuccess ? result.Message : ((result.ErrorMessage != null && result.ErrorMessage.Length > 0) ? string.Join(" , ", result.ErrorMessage) : "Unknown Error"));

            Console.WriteLine("~~~~ End SendSmsNotication ~~~~~~");
        }


        public void SendNotificationBycurryMethod()
        {
            Console.WriteLine("~~~~ Start Curry Style Notification~~~~~~");
            var notificationService = notficationServiceFactory.GetCurryStyleNotificationService();
            var smtpDetailProvider = notficationServiceFactory.GetSmtpDetails();
            var notificationServiceWithSmtpDetails = notificationService(smtpDetailProvider);

            for (int i = 1; i < 3; i++)
            {
                var userInfo = userProvider.GetUserById(i);
                var result = notificationServiceWithSmtpDetails(userInfo);
                Console.WriteLine(result.IsSuccess ? result.Message : ((result.ErrorMessage != null && result.ErrorMessage.Length > 0) ? string.Join(" , ", result.ErrorMessage) : "Unknown Error"));

            }

            Console.WriteLine("~~~~ End Curry Style Notification~~~~~~");
            Console.WriteLine("");

        }


        public void SendNotificationByPartialApplicationMethod()
        {
            Console.WriteLine("~~~~ Start Curry Style Notification~~~~~~");
            var emailNotificationService = notficationServiceFactory.GetNotificationService("email");

            for (int i = 1; i < 3; i++)
            {
                var result = userProvider
                .GetUserById(i)
                .SendNotification((u) => emailNotificationService(u));
                Console.WriteLine(result.IsSuccess ? result.Message : ((result.ErrorMessage != null && result.ErrorMessage.Length > 0) ? string.Join(" , ", result.ErrorMessage) : "Unknown Error"));

            }

            Console.WriteLine("~~~~ End Curry Style Notification~~~~~~");
            Console.WriteLine("");


        }
    }
}
