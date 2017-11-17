using FunctionalCurry.Common;
using System;

namespace FunctionalCurry.Oops
{
    public class EmailDetailsProvider
    {

        public  Tuple<string, string> GetEmailDetails(UserInfo userInfo)
        {
            var messageBody = $"<div><p>Hello{userInfo.FirstName},</p><br><p> this is test message from clean code.</p></div>";
            var subject = $"Hello {userInfo.FirstName}, this is notification message from clean code";
            return new Tuple<string, string>(subject, messageBody);
        }
    }
}
