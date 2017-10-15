using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_InversionPrinciple
{
    public class TransferAmounts
    {
        public decimal Amount { get; set; }
        public void Transfer(ITransferSource TransferSource, ITransferDestination TransferDestination)
        {
            TransferSource.RemoveFunds(Amount);
            TransferDestination.AddFunds(Amount);
        }
    }
}
