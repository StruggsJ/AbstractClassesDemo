using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
            * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
            * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
            * Provide the implementations for the abstract methods
            * Only in the Motorcycle class will you override the virtual drive method
           */

namespace ConsoleUI
{
    internal class Car : Vehicle
    {

        
        public bool HasCarInsurance { get; set; } = false;

        public override void DriveAbstract(Vehicle vehicle)
        {
            Console.WriteLine("Reminder: Don't forget about your complementary car wash!");
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Model: {Model}");

            if ( !HasCarInsurance )
            {
                Console.WriteLine("");
                Console.WriteLine("Reminder: Don't forget to get car insurance for your new car!");
                DriveAbstract(this);
                Console.WriteLine("--------");
            }
            else
            {
                Console.WriteLine("");
                DriveAbstract(this);
                Console.WriteLine("--------");
            }
        }
    }
}
