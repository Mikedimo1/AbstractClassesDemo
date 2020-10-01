using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles


            /*
             * DONE - Create an abstract class called Vehicle
             * DONE - The vehicle class shall have three string properties Year, Make, and Model
             * DONE - Set the defaults to something generic in the Vehicle class
             * DONE - Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE - Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONE - Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE - Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE - Provide the implementations for the abstract methods
             * DONE -Only in the Motorcycle class will you override the virtual drive method
            */

            // DONE - Create a list of Vehicle called vehicles
        var vehicles = new List<Vehicle>();
            /*
             * DONE - Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * DONE - Set the properties with object initializer syntax
             */
            Car fiesta = new Car() { HasTrunk = true, Make = "Ford" , Model = "Fiesta" ,  Year = "2010"};
            Motorcycle yamaha = new Motorcycle() { HasSideCar = false, Make = "Yamaha", Model = "Ninja", Year = "2015" };
            Vehicle GrandCherokee = new Car() { HasTrunk = false, Model = "Grand Cherokee", Year = "2018", Make = "Jeep" };
            Vehicle harley = new Motorcycle() { HasSideCar = true, Make = "Harley", Year = "2017", Model = "HardTail" };




            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(fiesta);
            vehicles.Add(yamaha);
            vehicles.Add(GrandCherokee);
            vehicles.Add(harley);

            foreach(var vehicle1 in vehicles)
            {
                Console.WriteLine($"Make {vehicle1.Make} Model {vehicle1.Model} Year {vehicle1.Year}");
                Console.WriteLine(" ");
                vehicle1.DriveAbstract();
                Console.WriteLine("-------------------------------- ");

            }

            // DONE - Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
