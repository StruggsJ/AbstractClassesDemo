using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

           
            Car car1 = new Car
            {
                Name = "Acura",
                Model = "TLX",
                Year = "2014"

            };

            Motorcycle motorcycle1 = new Motorcycle
            {
                Name = "Harley-Davidson",
                Model = "XLCR",
                Year = "1977",
            };

            Vehicle car2 = new Car
            {
                Name = "Chevrolet",
                Model = "Cruze",
                Year = "2010",

                HasCarInsurance = true,
            };

            Vehicle motorcycle2 = new Motorcycle
            {
                Name = "Honda",
                Model = "XR 650L",
                Year = "2023",

                HasCycleInsurance = true,
            };


            /*
            * Add the 4 vehicles to the list
            * Using a foreach loop iterate over each of the properties
            */

            List<Vehicle> vehicleLog = new List<Vehicle>();

                vehicleLog.Add(car1);
                vehicleLog.Add(motorcycle1);
                vehicleLog.Add(car2);
                vehicleLog.Add(motorcycle2);

            foreach (var vehicle in vehicleLog)
            {
                vehicle.PrintDetails();  // Call each of the drive methods for one car and one motorcycle
            }

            

            #endregion
            Console.ReadLine();

        }
    }

}

