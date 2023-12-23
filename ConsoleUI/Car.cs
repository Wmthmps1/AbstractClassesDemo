using System;
namespace ConsoleUI
{
	public class Car : Vehicle
	{
		public Car()
		{
		}

        public bool HasTrunk { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The car drives like a regular vehicle.");
        }

        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }

    }
}

/*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             


 * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
 * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
 * Provide the implementations for the abstract methods
 * Only in the Motorcycle class will you override the virtual drive method
 * */