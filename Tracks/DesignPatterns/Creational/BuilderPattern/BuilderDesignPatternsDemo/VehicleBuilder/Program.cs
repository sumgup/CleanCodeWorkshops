using System;
using VehicleBuilder.ConcreteBuilder;
using VehicleBuilder.Director;

namespace VehicleBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var heroCreator = new VehicleCreator(new HeroBuilder());
            
            heroCreator.CreateVehicle();
            var heroVehicle = heroCreator.GetVehicle();
            heroVehicle.ShowInfo();


            var bajajCreator = new VehicleCreator(new BajajBuilder());
            bajajCreator.CreateVehicle();
            var bajajVehicle = bajajCreator.GetVehicle();
            bajajVehicle.ShowInfo();

            var hondaCreator = new VehicleCreator(new HondaBuilder());
            hondaCreator.CreateVehicle();
            var hondaVehicle = hondaCreator.GetVehicle();
            hondaVehicle.ShowInfo();

            Console.ReadKey();

        }
    }
}
