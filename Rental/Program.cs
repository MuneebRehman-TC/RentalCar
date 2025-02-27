using System;
using System.Collections.Generic;

namespace Rental
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            string continueOption;
            do
            {
                Console.WriteLine("Select Option");
                Console.WriteLine("1. Create");
                Console.WriteLine("2. Update");
                Console.WriteLine("3. Delete");
                Console.WriteLine("4. Get");
                Console.WriteLine();

                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Brand");
                        car.Brand = Console.ReadLine();
                        Console.WriteLine("Enter Model");
                        car.Model = Console.ReadLine();
                        car.Create();
                        break;
                    case 2:
                        Console.WriteLine("Enter Brand");
                        car.Brand = Console.ReadLine();
                        Console.WriteLine("Enter Model");
                        car.Model = Console.ReadLine();
                        car.Update();
                        break;
                    case 3:
                        Console.WriteLine("Enter Brand");
                        car.Brand = Console.ReadLine();
                        Console.WriteLine("Enter Model");
                        car.Model = Console.ReadLine();
                        car.Delete();
                        break;
                    case 4:
                        car.Get();
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }

           
                do
                {
                    Console.WriteLine("Do you want to continue? (Y/N)");
                    continueOption = Console.ReadLine().ToUpper();

                    if (continueOption != "Y" && continueOption != "N")
                    {
                        Console.WriteLine("Invalid input. Please enter 'Y' for yes or 'N' for no.");
                    }

                } while (continueOption != "Y" && continueOption != "N");

            } while (continueOption == "Y");
        }
    }
}
