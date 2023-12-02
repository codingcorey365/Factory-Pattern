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
                   
                case 2:
                    return new Motorcyle();
                   
                case 3:
                    return new ThreeWheeler();
                   
                case 6:
                    return new Truck();
                   
                case 18:
                    return new BigRig();
                   
                default:
                    return new Car();
                   
            }
        }

        
        
        public static IVehicle CreateVehicleOfFourWheels (int result2)
        {
            
            switch (result2)
            {
                case 1:
                    IVehicle car = new Suv();
                    car.Drive();
                    return new Car();
                    
                case 2:                    
                    IVehicle suv = new Suv();
                    suv.Drive();
                    return suv;

                case 3:
                   IVehicle truck = new Suv();
                   truck.Drive();
                   return new Truck();

                default:
                    return new Car();
                    
            }
        }
        

}
}
