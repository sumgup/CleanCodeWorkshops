using VehicleBuilder.Product;

namespace VehicleBuilder.Builder
{
    public interface IVehicleBuilder
    {
      void  WithModel();
      void  WithEngine();
      void  WithTransmission();
      void  WithBody();
      void  WithAccessories();
      Vehicle GetVehicle();
    }
}
