using FunctionalCurry.Common;
using System;

namespace FunctionalCurry.Oops
{
    public class SmsDetailsProvider
    {
        public  Tuple<string, string> GetSmsDetails(UserInfo userInfo)
        {
            var messageBody = $"Hello {userInfo.FirstName}, this is test message from clean code";
            var fromNumber = "+919723812403";
            return new Tuple<string, string>(fromNumber, messageBody);
        }
    }
}
