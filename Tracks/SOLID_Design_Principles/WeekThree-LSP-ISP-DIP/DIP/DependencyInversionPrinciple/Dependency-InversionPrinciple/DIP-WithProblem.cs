using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_InversionPrinciple
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    namespace SOLIDPrinciplesDemo
    {
        //DIP Violation 
        // Low level Class 
        public class BankAccount
        {
            public string AccountNumber { get; set; }
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
        // High level Class 
        public class TransferAmount
        {
            public BankAccount Source { get; set; }
            public BankAccount Destination { get; set; }
            public decimal Value { get; set; }

            public void Transfer()
            {
                Source.RemoveFunds(Value);
                Destination.AddFunds(Value);
            }
        }
    }
}
//Problem with above design: 
  
//1. The high level TransferAmount class is directly dependent upon the lower level BankAccount class i.e.Tight coupling.
//2. The Source and Destination properties reference the BankAccount type.So impossible to substitute other account types unless they are subclasses of BankAccount.
//3. Later we want to add the ability to transfer money from a bank account to pay bills, the BillAccount class would have to inherit from BankAccount.
// As bills would not support the removal of funds,  
// 3.A.This is likely to break the rules of the Liskov Substitution Principle(LSP) or  
// 3.B.Require changes to the TransferAmount class that do not comply with the Open/Closed Principle(OCP). 
  
//4. Any extension functionality changes be required to low level modules.
// 4.A.Change in the BankAccount class may break the TransferAmount.
// 4.B.In complex scenarios, changes to low level classes can cause problems that cascade upwards through the hierarchy of modules.  
//5. As the software grows, this structural problem can be compounded and the software can become fragile or rigid.
//6. Without the DIP, only the lowest level classes may be easily reusable.
//7. Unit testing should be redone when there is a change in high level or low level classes. 
//8. Time taken process to change the existing functionality and extending the functionality 
