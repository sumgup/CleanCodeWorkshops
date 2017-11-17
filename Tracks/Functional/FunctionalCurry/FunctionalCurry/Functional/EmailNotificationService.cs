using FunctionalCurry.Common;
using System;
using System.Configuration;
using System.Net.Mail;

namespace FunctionalCurry.Functional
{
    public static class EmailNotificationService
    {

        #region "Partial Application"
        public static Func<UserInfo, Outcome> GetComposedEmailNotificationService()
        {
            Console.WriteLine(" Email Composition Start ");
            Func<UserInfo, Tuple<string, string>> getEmaDetails = (u) => GetEmailDetails(u);


            Func<Tuple<string, int, string, string, string>> getSmtpServerDetails = () => GetSmtpServerDetails();
            Console.WriteLine(" Email Composition End ");
            return GetEmailNotificationService(getEmaDetails, getSmtpServerDetails);
           // return getEmaDetails.Then(getSmtpServerDetails);


        }

        private static Func<UserInfo, Outcome> Then(this Func<UserInfo, Tuple<string, string>> getEmaDetails, Func<Tuple<string, int, string, string, string>> getSmtpServerDetails)
        {
            return GetEmailNotificationService(getEmaDetails, getSmtpServerDetails);
        }

        private static Func<UserInfo, Outcome> GetEmailNotificationService(Func<UserInfo, Tuple<string, string>> getEmaDetails, Func<Tuple<string, int, string, string, string>> getSmtpDetails)
        {
            return (UserInfo userInfo) =>
            {
                try
                {
                    Console.WriteLine("*************** Core Start  *********************");
                    var emailDetails = getEmaDetails(userInfo);
                    var smtpDetails = getSmtpDetails();

                    using (var smtpClient = new SmtpClient(smtpDetails.Item1, smtpDetails.Item2))
                    {
                        smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                        smtpClient.Credentials = new System.Net.NetworkCredential(smtpDetails.Item3, smtpDetails.Item4);
                        smtpClient.EnableSsl = true;
                        MailMessage mail = new MailMessage(smtpDetails.Item5, userInfo.EmailId);
                        mail.Subject = emailDetails.Item1;
                        mail.Body = emailDetails.Item2;
                        mail.IsBodyHtml = true;
                        

                        
                         smtpClient.Send(mail);
                    }
                    Console.WriteLine("*************** Core End  *********************");
                    return Outcome.Ok( "Email send successfully");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("*************** Core End  *********************");
                    return Outcome.Fail( ex.Message);
                }
            };
        }

        #endregion

        private static Tuple<string, string> GetEmailDetails(UserInfo userInfo)
        {
            Console.WriteLine("!!!!!!!! Email Details Start !!!!!!!! ");
            var messageBody = $"<div><p>Hello{userInfo.FirstName},</p><br><p> this is test message from clean code.</p></div>";
            var subject = $"Hello {userInfo.FirstName}, this is notification message from clean code";
            Console.WriteLine("!!!!!!!! Email Details End !!!!!!!! ");
            return new Tuple<string, string>(subject, messageBody);
        }


        public static Tuple<string, int, string, string, string> GetSmtpServerDetails()
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("*************** Smtp Called  *********************");
            Console.ForegroundColor = originalColor;
            return new Tuple<string, int, string, string, string>(ConfigurationManager.AppSettings["smtp:server"], int.Parse(ConfigurationManager.AppSettings["smtp:port"]), ConfigurationManager.AppSettings["smtp:userName"],
                ConfigurationManager.AppSettings["smtp:password"], ConfigurationManager.AppSettings["smtp:senderEmailId"]);


        }

        #region "CurryWay"

        public static Func<Func<Tuple<string, int, string, string, string>>, Func<UserInfo, Outcome>> GetComposedEmailNotificationServiceByCurryWay()
        {
            

            return (smtpdetailsFunc) => /// step1 
            {
                var smtpInfo = smtpdetailsFunc();

                return (UserInfo userInfo) =>  //step 2
                {
                    var emailDetails = GetEmailDetails(userInfo);

                    return SendAnEmail(userInfo, emailDetails.Item1, emailDetails.Item2, smtpInfo.Item1, smtpInfo.Item2, smtpInfo.Item3, smtpInfo.Item4, smtpInfo.Item5);
                };

            };



        }

        private static Outcome SendAnEmail(UserInfo userInfo, string subject, string messageBody, string server, int port, string userName, string password, string senderEmailId)
        {
            try
            {

                Console.WriteLine("*************** Core Start  *********************");
                using (var smtpClient = new SmtpClient(server, port))
                {
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.Credentials = new System.Net.NetworkCredential(userName, password);
                    smtpClient.EnableSsl = true;
                    MailMessage mail = new MailMessage(senderEmailId, userInfo.EmailId);
                    mail.Subject = subject;
                    mail.Body = messageBody;
                    mail.IsBodyHtml = true;
                   // smtpClient.Send(mail);
                }



                
                Console.WriteLine("*************** Core End  *********************");
                return Outcome.Ok("Email send successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("*************** Core End  *********************");
                return Outcome.Fail(ex.Message);
            }
        }

        
        

        public static Func<string, int, string, string, string, Func<UserInfo, string, string, Outcome>> CurryForSmtpDetails(this Func<UserInfo, string, string, string, int, string, string, string, Outcome> func)
        {
              
            return (string server, int port, string userName, string password, string senderEmailId) =>
            {
                return (UserInfo userInfo, string subject, string messageBody) =>
                {
                    return func(userInfo, subject, messageBody, server, port, userName, password, senderEmailId);
                };
            };
        }

       

        

        #endregion

        

    }
}
