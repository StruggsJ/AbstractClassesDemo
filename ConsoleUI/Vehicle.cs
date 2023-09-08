using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
          * Create an abstract class called Vehicle
          * The vehicle class shall have three string properties Year, Make, and Model
          * Set the defaults to something generic in the Vehicle class
          * Vehicle shall have an abstract method called DriveAbstract with no implementation
          * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
          */

namespace ConsoleUI
{
    abstract class Vehicle
    {
        public string Year { get; set; } = "1990";
        public string Name { get; set; } = "Ford";
        public string Model { get; set; } = "Explorer";

        public abstract void DriveAbstract(Vehicle vehicle);
       
        public virtual void DriveVirtual(Vehicle vehicle)
        {
            Console.WriteLine($"Reminder: Don't forget to wash your vehicle!");
        }

        public abstract void PrintDetails();
        

    }
}
