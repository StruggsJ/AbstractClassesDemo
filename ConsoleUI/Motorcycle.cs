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
    internal class Motorcycle : Vehicle
    {

        public bool HasCycleInsurance { get; set; } = false;

        public override void DriveAbstract(Vehicle vehicle)
        {

            Console.WriteLine("Reminder: Don't forget about your complementary wash for your motocycle!");
        }

        public override void DriveVirtual(Vehicle vehicle)
        {
            Console.WriteLine("Reminder: Don't forget to buy a helment for your motocycle!");
        }

        public override void PrintDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Model: {Model}");

            if (!HasCycleInsurance)
            {
                Console.WriteLine("");
                Console.WriteLine("Reminder: Don't forget to get motorcycle insurance for your new motorcycle!");
                DriveAbstract(this);
                DriveVirtual(this);
                Console.WriteLine("--------");
            }
            else
            {
                Console.WriteLine("");
                DriveAbstract(this);
                DriveVirtual(this);
                Console.WriteLine("--------");
            }
        }
    }
}
