using FunctionalCurry.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCurry.Oops
{
    public static class Demo
    {

        public static void Run()
        {
            IUserProvider userProvider = new UserProvider();
            var notificationProvider = new NotficationServiceFactory();
            var controller = new MyController(userProvider, notificationProvider);

           controller.SendSmsNotication(1);

            //controller.SendEmailNotication(1);
            
        }
    }


}
