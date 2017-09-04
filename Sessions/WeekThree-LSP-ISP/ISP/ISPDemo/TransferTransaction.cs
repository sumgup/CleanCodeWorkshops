using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPDemo
{
    public class TransferTransaction : Transaction
    {
        public ITransferUI _transferUI;

        public TransferTransaction(ITransferUI transferUI)
        {
            _transferUI = transferUI;
        }

        public override void Execute()
        {
            _transferUI.RequestTransferAmount();
        }
    }
}