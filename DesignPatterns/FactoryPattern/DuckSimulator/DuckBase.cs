using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckSimulator
{
    public abstract class DuckBase
    {
        private IFlyBehavior flyBehavior;
        private IQuackBehavior quackBehavior;

        public IFlyBehavior FlyBehavior { get => flyBehavior; set => flyBehavior = value; }
        public IQuackBehavior QuackBehavior { get => quackBehavior; set => quackBehavior = value; }

        public void PerformFly()
        {
            FlyBehavior.Fly();
        }

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void Swim()
        {
            throw new System.NotImplementedException();
        }

        public abstract void Display();
        
    }
}