using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_InversionPrinciple
{
    public interface ITransferSource
    {
        long AccountNumber { get; set; }
        decimal Balance { get; set; }
        void RemoveFunds(decimal value);
    }
}
