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
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles


            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion

            var vehicles = new List<Vehicle>();

            var accord = new Car() {HasTrunk = true, Year = "2001", Make = "Honda", Model = "Accord" };
            var kawasaki = new Motorcycle() { HasSideCar = true, Year = "2023", Make = "Kawasaki", Model = "Z400" };
            Vehicle truck = new Car() {HasTrunk = false, Year = "2022", Make = "Ford", Model = "F-150" };
            Vehicle sportsBike = new Motorcycle() { HasSideCar = false, Year = "2022", Make = "Honda", Model = "CBR 1225" };

            vehicles.Add(accord);
            vehicles.Add(kawasaki);
            vehicles.Add(truck);
            vehicles.Add(sportsBike);

            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine($"{v.Year} {v.Make} {v.Model}");
                v.DriveAbstract();
                v.DriveVirtual();
                Console.WriteLine("_________________________________________________");


            }

        }
    }
}
