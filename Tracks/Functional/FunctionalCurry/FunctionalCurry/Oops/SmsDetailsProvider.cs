using FunctionalCurry.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalCurry.Oops
{
    public class SmsDetailsProvider
    {
        public  Tuple<string, string> GetSmsDetaills(UserInfo userInfo)
        {
            var messageBody = $"Hello {userInfo.FirstName}, this is test message from clean code";
            var fromNumber = "+919723812403";
            return new Tuple<string, string>(fromNumber, messageBody);
        }
    }
}
