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
         public static IVehicle GetVehicle(int result) 
        {
            switch (result)
            {
                case 1:
                    return new Unicycle();
                    break;
                case 2:
                    return new Motorcyle();
                    break;
                case 3:
                    return new ThreeWheeler();
                    break;
                case 6:
                    return new Truck();
                    break;
                case 18:
                    return new BigRig();
                    break;
                default:
                    return new Car();
                    break;
            }
        }

        
        
        public static IVehicle CreateVehicleOfFourWheels (int result2)
        {
            
            switch (result2)
            {
                case 1:
                    return new Car();
                    IVehicle car = VehicleFactory.CreateVehicleOfFourWheels(result2);
                    car.Drive();
                    break;
                case 2:
                    return new Suv();
                    IVehicle suv = VehicleFactory.CreateVehicleOfFourWheels(result2);
                    suv.Drive();
                    break;
                case 3:
                    return new Truck();
                    IVehicle truck = VehicleFactory.CreateVehicleOfFourWheels(result2);
                   truck.Drive();
                    break;
                default:
                    return new Car();
                    break;
            }
        }
        

}
}
