using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleBuilder.Builder;
using VehicleBuilder.Product;

namespace VehicleBuilder.ConcreteBuilder
{
    public class HondaBuilder : IVehicleBuilder
    {
        Vehicle objVehicle = new Vehicle();
        public void WithModel()
        {
            objVehicle.Model = "Honda";
        }

        public void WithEngine()
        {
            objVehicle.Engine = "4 Stroke";
        }

        public void WithTransmission()
        {
            objVehicle.Transmission = "125 Km/hr";
        }

        public void WithBody()
        {
            objVehicle.Body = "Plastic";
        }

        public void WithAccessories()
        {
            objVehicle.Accessories.Add("Seat Cover");
            objVehicle.Accessories.Add("Rear Mirror");
            objVehicle.Accessories.Add("Helmet");
        }

        public Vehicle GetVehicle()
        {
            return objVehicle;
        }
    }
}
