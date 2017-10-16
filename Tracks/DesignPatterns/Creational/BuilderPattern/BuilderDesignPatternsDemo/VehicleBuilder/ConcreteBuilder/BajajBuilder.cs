using VehicleBuilder.Builder;
using VehicleBuilder.Product;

namespace VehicleBuilder.ConcreteBuilder
{
    public class BajajBuilder : IVehicleBuilder
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
            vehicle.Accessories.Add("Tyers");
        }

        public void WithBody()
        {
            vehicle.Body = "Plastic";
        }

        public void WithEngine()
        {
            vehicle.Engine = "5 stroke";
        }

        public void WithModel()
        {
            vehicle.Model = "Bajaj";
        }

        public void WithTransmission()
        {
            vehicle.Transmission = "150KMPH";
        }
    }
}
