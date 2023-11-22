using System.Buffers.Text;
using System.ComponentModel;
using System;

namespace FactoryPattern
{
    // Exercise 1

    // Fork and Clone the repository to your local computer:
    // Factory Pattern Exercise Repo
    
    // 1.
    // Create a console app that utilizes factory pattern by taking a user’s input of how many tires are on a vehicle and, based on their input, creates that type of
    // vehicle.

    // 2.
    // Complete this using an interface. You must have at least 2 subclasses.For instance, if I type 4 into the console, the program would create a car or truck, or if
    // someone types 2 it would create a motorcycle.

    // Feel free to use something other than vehicles if you want to be creative, but the other constraints still apply!
    
    // 3.
    // Create an Interface named IVehicle that has a stubbed out public void Drive method.

    // 4. 
    // Create 2 new public classes that will conform to IVehicle.
    // Example) Car, Motorcycle, BigRig
    // Note: These classes must conform to IVehicle and implement the Drive() method - which will just Console.WriteLine(“Building a new Car!”)

    // 5.
    // Now we will make our static VehicleFactory class.

    // 6.
    // It will contain a static method GetVehicle(), that will return an IVehicle based on the amount of tires it’s given as a parameter

    // 7. 
    // Call this functionality in the Main method.
    
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, How many tires are on your vehicle you desire?");

            var userInput = Console.ReadLine();
        }
    }
}
