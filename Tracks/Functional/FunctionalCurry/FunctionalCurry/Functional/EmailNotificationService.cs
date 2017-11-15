using FunctionalCurry.Common;
using System;
using System.Configuration;
using System.Net.Mail;

namespace FunctionalCurry.Functional
{
    public static class EmailNotificationService
    {

        public static Func<UserInfo, Outcome> GetComposedEmailNotificationService()
        {
            Func<UserInfo, Tuple<string, string>> getEmaDetails = (u) => GetEmailDetaills(u);

            Func<Tuple<string, int, string, string, string>> getSmtpServerDetails = () => GetSmtpServerDetails();

            return GetEmailNotificationService(getEmaDetails, getSmtpServerDetails);
        }

        private static Func<UserInfo, Outcome> GetEmailNotificationService(Func<UserInfo, Tuple<string, string>> getEmaDetails, Func<Tuple<string, int, string, string, string>> getSmtpDetails)
        {
            return (UserInfo userInfo) =>
            {
                try
                {
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
                        smtpClient.Send(mail);
                    }

                    return Outcome.Ok( "Email send successfully");
                }
                catch (Exception ex)
                {

                    return Outcome.Fail( ex.Message);
                }
            };
        }


        private static Tuple<string, string> GetEmailDetaills(UserInfo userInfo)
        {
            var messageBody = $"<div><p>Hello{userInfo.FirstName},</p><br><p> this is test message from clean code.</p></div>";
            var subject = $"Hello {userInfo.FirstName}, this is notification message from clean code";
            return new Tuple<string, string>(subject, messageBody);
        }


        private static Tuple<string, int, string, string, string> GetSmtpServerDetails()
        {
            return new Tuple<string, int, string, string, string>(ConfigurationManager.AppSettings["smtp:server"], int.Parse(ConfigurationManager.AppSettings["smtp:port"]), ConfigurationManager.AppSettings["smtp:userName"],
                ConfigurationManager.AppSettings["smtp:password"], ConfigurationManager.AppSettings["smtp:senderEmailId"]);

        }
    }
}
