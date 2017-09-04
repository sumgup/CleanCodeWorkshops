using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPDemo
{
    

    public class UIGlobals
    {
        public static IWithdrawlUI withdrawl;
        public static ITransferUI transfer;
        public static IDepositUI depositUI;

        static UIGlobals()
        {

        }
    }
}
