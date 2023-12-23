using System;
namespace ConsoleUI
{
    public abstract class Vehicle
    {
        
        public string Year { get; set; } = "Vehicle Year";
        public string Make { get; set; } = "Vehicle Make";
        public string Model { get; set; } = "Vehicle Model";


        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("The car drives differently from a motorcycle.");
        }

	}
}

/*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */