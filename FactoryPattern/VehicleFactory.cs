using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    // 6.
    // It will contain a static method GetVehicle(),
    // that will return an IVehicle based on the
    // amount of tires it’s given as a parameter
    public static class VehicleFactory
    {
         public static IVehicle GetVehicle(string userinput) 
        {
            //var vehicle = new Truck(userinput);
            //var numberOfTires = int.Parse(userinput);
            return new Motorcyle();
        }
    }
}
