using DuckSimulator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();

            var model = new ModelDuck();
            // Changing the behavior at run time
            model.FlyBehavior = new FlyRocketPowered();
            model.PerformFly();

            Console.Read();
        }
    }
}
