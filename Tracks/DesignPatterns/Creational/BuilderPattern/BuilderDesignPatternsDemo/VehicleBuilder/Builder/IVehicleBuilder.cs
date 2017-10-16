using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleBuilder.Product;

namespace VehicleBuilder.Builder
{
    public interface IVehicleBuilder
    {
      void  WithModel();
      void  WithEngine();
      void  WithTransmission();
      void WithBody();
      void WithAccessories();
      Vehicle GetVehicle();
    }
}
