using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_InversionPrinciple
{
    public class BOABankAccount : ITransferSource, ITransferDestination
    {
        public long AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public void AddFunds(decimal value)
        {
            Balance += value;
        }
        public void RemoveFunds(decimal value)
        {
            Balance -= value;
        }
    }
}
