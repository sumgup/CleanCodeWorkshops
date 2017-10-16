using VehicleBuilder.Builder;
using VehicleBuilder.Product;

namespace VehicleBuilder.ConcreteBuilder
{
    public class HeroBuilder : IVehicleBuilder
    {
        Vehicle vehicle = new Vehicle();
        public Vehicle GetVehicle()
        {
            return vehicle;
        }

        public void WithAccessories()
        {
            vehicle.Accessories.Add("Seat Cover");
            vehicle.Accessories.Add("Engine");
            vehicle.Accessories.Add("Mirror");

        }

        public void WithBody()
        {
            vehicle.Body = "Plastic";
        }

        public void WithEngine()
        {
            vehicle.Engine = "4 Stroke";
        }

        public void WithModel()
        {
            vehicle.Model = "Hero";
        }

        public void WithTransmission()
        {
            vehicle.Transmission = "130 KMPH";
        }
    }
}
