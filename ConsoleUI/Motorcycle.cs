using System;
using ConsoleUI;

namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
		public Motorcycle()
		{
		}
        
        public bool HasSideCar { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle drives like a regular vehicle.");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("The motorcycle drives differently from a car");
        }
    }
}

/*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             
*Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
 * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
 * Provide the implementations for the abstract methods
 * Only in the Motorcycle class will you override the virtual drive method
*/ 
