using FunctionalCurry.Common;

namespace FunctionalCurry.Functional
{
    public static class Demo
    {


        public static void Run()
        {
            IUserProvider userProvider = new UserProvider();
            var notficationServiceFactory = new NotficationServiceFactory();
            var myController = new MyController(userProvider, notficationServiceFactory);

            myController.SendEmailNotication(1);
            myController.SendSmsNotication(1);
        }

    }
}
