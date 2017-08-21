using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckSimulator
{
    public class MallardDuck : DuckBase
    {
        public MallardDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
        }

       
    }
}