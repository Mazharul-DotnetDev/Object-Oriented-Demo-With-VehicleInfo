using ObjectOrientedWithVehicleInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedWithVehicleInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Vehicle Management System");
            Console.WriteLine("-----------------------------------");

            while (true)
            {
                Console.WriteLine("Here are the options to choose:");
                Console.WriteLine("1. Manage Cars");
                Console.WriteLine("2. Manage Motorcycles");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Select any one of these options:");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        ManageCars();
                        break;
                    case 2:
                        ManageMotorcycles();
                        break;
                    case 3:
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
            }
        }

        static void ManageCars()
        {
            Console.WriteLine("Managing Cars");
            Console.WriteLine("-------------");

            // Example usage of Car class
            using (Car<string> car = new Car<string>("A3", "Bmw"))
            {
                car.AddInteriorDesign("Color: Red", "Driver position: Right");
                car.DisplayInfo();
            }

            Console.WriteLine();
        }

        static void ManageMotorcycles()
        {
            Console.WriteLine("Managing Motorcycles");
            Console.WriteLine("--------------------");

            // Example usage of Motorcycle class
            using (Motorcycle<string> motorcycle = new Motorcycle<string>("M20", "Suzuki"))
            {
                motorcycle.AddExteriorDesign("Color: Blue", "HeadLight: LED");
                motorcycle.DisplayInfo();
            }

            Console.WriteLine();
        }
    }
}
