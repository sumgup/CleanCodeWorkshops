using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckSimulator
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("FlyNoWay");

        }
    }
}