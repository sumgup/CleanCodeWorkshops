using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckSimulator
{
    public class RubberDuck : DuckBase
    {

        public RubberDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            throw new NotImplementedException();
        }

       
    }
}