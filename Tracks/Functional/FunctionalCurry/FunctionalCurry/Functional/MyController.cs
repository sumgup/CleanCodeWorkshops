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


        }

        public void SendSmsNotication(int userId)
        {
            var smsNotificationService = notficationServiceFactory.GetNotificationService("sms");
            var userInfo = userProvider.GetUserById(userId);
            var result = smsNotificationService(userInfo);

           // var result = userProvider.GetUserById(userId).SendNotification((u) => smsNotificationService(u));
            Console.WriteLine(result.IsSuccess ? result.Message : ((result.ErrorMessage != null && result.ErrorMessage.Length > 0) ? string.Join(" , ", result.ErrorMessage) : "Unknown Error"));

        }
    }
}
