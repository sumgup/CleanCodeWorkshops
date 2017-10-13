using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dependency_InversionPrinciple
{
    class DependencyInversionPrincipleDemo
    {
        public static void Main(string []args)
        {
            Console.WriteLine("\n\nDependency Inversion Principle Demo ");

            //Created abstract class/interfaces objects for low level classes. 
            ITransferSource TransferSource = new BOABankAccount();
            TransferSource.AccountNumber = 123456789;
            TransferSource.Balance = 1000;
            Console.WriteLine("Balance in Source Account : " + TransferSource.AccountNumber + " Amount " + TransferSource.Balance);

            ITransferDestination TransferDestination = new BOABankAccount();
            TransferDestination.AccountNumber = 987654321;
            TransferDestination.Balance = 0;
            Console.WriteLine("Balance in Destination Account : " + TransferDestination.AccountNumber + " Amount " + TransferDestination.Balance);


            TransferAmounts TransferAmountsObject = new TransferAmounts();
            TransferAmountsObject.Amount = 100;

            // High level class using abstract class/interface objects  
            TransferAmountsObject.Transfer(TransferSource, TransferDestination);
            Console.WriteLine("Transaction successful");

            Console.WriteLine("Balance in Source Account : " + TransferSource.AccountNumber + " Amount " + TransferSource.Balance);
            Console.WriteLine("Balance in Destination Account : " + TransferDestination.AccountNumber + " Amount " + TransferDestination.Balance);
            Console.ReadLine();
        }
    }
}
