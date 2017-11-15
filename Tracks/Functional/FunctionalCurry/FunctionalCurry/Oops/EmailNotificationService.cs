using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using FunctionalCurry.Common;

namespace FunctionalCurry.Oops
{
    public class EmailNotificationService : INotificationService
    {
     

        private string smtpHost;

        private int port;
        private string userName;

        private string password;

        private EmailDetailsProvider emailDetailsProvider;
        private string senderEmailId;

        public EmailNotificationService( EmailDetailsProvider emailDetailsProvider, string smtpHost, int port, string userName, string password,string senderEmailId)
        {
            this.password = password;
            this.smtpHost = smtpHost;
            this.port = port;
            this.userName = userName;
            this.emailDetailsProvider = emailDetailsProvider;
            this.senderEmailId = senderEmailId;
        }

        public Outcome SendNotification(UserInfo userInfo)
        {
           
            try
            {
                var emailDetails = emailDetailsProvider.GetEmailDetaills(userInfo); ;
                
                using (var smtpClient = new SmtpClient(smtpHost, port))
                {
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.Credentials = new System.Net.NetworkCredential(userName, password);
                    smtpClient.EnableSsl = true;
                    MailMessage mail = new MailMessage(senderEmailId, userInfo.EmailId);
                    mail.Subject = emailDetails.Item1;
                    mail.Body = emailDetails.Item2;
                    mail.IsBodyHtml = true;
                    smtpClient.Send(mail);
                }

                return  Outcome.Ok( "Email send successfully");
            }
            catch (Exception ex)
            {

                return  Outcome.Fail( ex.Message);
            }
        }
    }
}
