using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckSimulator
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}