using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckSimulator
{
    public class ModelDuck : DuckBase
    {
        public ModelDuck()
        {
            Console.WriteLine("MOdel duck ctor");
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new Quack();
        }

       
        public override void Display()
        {

        }
        
    }
}