﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPDemo
{
    public interface UI : IDepositUI, IWithdrawlUI,ITransferUI
    {
       
    }
}