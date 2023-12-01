using System.Buffers.Text;
using System.ComponentModel;
using System;

namespace FactoryPattern
{
    // Exercise 1

    // Fork and Clone the repository to your local computer:
    // Factory Pattern Exercise Repo
    
    // 1.
    // Create a console app that utilizes factory pattern
    // by taking a user’s input of how many tires are on a vehicle
    // and, based on their input, creates that type of vehicle.

    // 2.
    // Complete this using an interface.
    // You must have at least 2 subclasses.
    // For instance, if I type 4 into the console,
    // the program would create a car or truck,
    // or if someone types 2 it would create a motorcycle.

    /* Feel free to use something other than vehicles
     * if you want to be creative,
     * but the other constraints still apply! */
    
    // 3.
    // Create an Interface named IVehicle
    // that has a stubbed out public void Drive method.

    // 4. 
    // Create 2 new public classes
    // that will conform to IVehicle.
    // Example) Car, Motorcycle, BigRig
    //
    // Note: These classes must conform to IVehicle
    // and implement the Drive() method
    // - which will just Console.WriteLine(“Building a new Car!”)

    // 5.
    // Now we will make our static VehicleFactory class.

    // 6.
    // It will contain a static method GetVehicle(),
    // that will return an IVehicle based on the
    // amount of tires it’s given as a parameter

    // 7. 
    // Call this functionality in the Main method.
    
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, How many tires are on your vehicle do you desire?");
            bool input;
            bool input2;

            input = int.TryParse(Console.ReadLine(), out int result);
            if (input == false)
            {
                Console.WriteLine("Not a valid input. Please try again with the correct option. Enter: 0, 1, 2, 3, 4, 6, 18.");
            }
            Console.WriteLine("----------------------------------");
            switch (result)
            {
                case 0:
                    Console.WriteLine("I don't have a car :(");
                    break;
                case 1:
                    Console.WriteLine("I have a unicycle");
                    IVehicle unicylce = VehicleFactory.GetVehicle(result);
                    unicylce.Drive();
                    break;
                case 2:
                    Console.WriteLine("Its a motorcycle not a bike, I promise!");
                    IVehicle motorcycle = VehicleFactory.GetVehicle(result);
                    motorcycle.Drive();
                    break;
                case 3:
                    Console.WriteLine("Im a motorcycle with a side cart. or a three wheeler. You decide!");
                    IVehicle threewheeler = VehicleFactory.GetVehicle(result);
                    threewheeler.Drive();
                    break;
                case 4:
                    Console.WriteLine("I could be a few different things. Lets clarify.");
                    Console.WriteLine("There are several vehicles that come with four wheels. Pick a number that best fits your vehicle.");
                    Console.WriteLine("1. You have a Car.");
                    Console.WriteLine("2. You have an Suv");
                    Console.WriteLine("3. You have a Truck");

                    input2 = int.TryParse(Console.ReadLine(), out int result2);
                    if (input2 == false)
                    {
                        Console.WriteLine("Not a valid input. Please try again with the correct option. Enter: 1, 2, or 3.");
                    }
                    if (result2 < 1 || result2 > 3)
                    {
                        Console.WriteLine("Not a valid input. Please try again with the correct option. Enter: 1, 2, or 3.");
                    }
                    else
                    {                        
                        if(result2 == 1 )
                        {
                            VehicleFactory.CreateVehicleOfFourWheels(result2);
                            
                        }
                        if (result2 == 2)
                        {
                            VehicleFactory.CreateVehicleOfFourWheels(result2);
                        }
                        if (result2 == 3)
                        {
                            VehicleFactory.CreateVehicleOfFourWheels(result2);
                        }
                    }
                    
                    break;
                case 6:
                    Console.WriteLine("Im a dually for dual purpose");
                    IVehicle dually = VehicleFactory.GetVehicle(result);
                    dually.Drive();
                    break;
                case 18:
                    Console.WriteLine("Im a big rig :D");
                    IVehicle bigrig = VehicleFactory.GetVehicle(result);
                    bigrig.Drive();
                    break;
                default:
                    Console.WriteLine("I'm not sure I have heard of that vehicle.");
                    break;
            }   
            Console.WriteLine("----------------------------------");
            
            
        }
    }
}
