using VehicleBuilder.Builder;
using VehicleBuilder.Product;

namespace VehicleBuilder.Director
{
    public class VehicleCreator
    {
        public readonly IVehicleBuilder builder;

        public VehicleCreator(IVehicleBuilder builder)
        {
            this.builder = builder;
        }
        
        public void CreateVehicle()
        {
            builder.WithModel();
            builder.WithEngine();
            builder.WithBody();
            builder.WithTransmission();
            builder.WithAccessories();
        }
        public Vehicle GetVehicle()
        {
            return builder.GetVehicle();
        }
    }
}
