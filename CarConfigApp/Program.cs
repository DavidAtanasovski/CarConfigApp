using System;
using System.Collections.Generic;
using System.Linq;

namespace CarConfigApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicle = new Vehicle();
            vehicle.Engine = CreateEngine();
            vehicle.AddPart(CreateEngine());
            vehicle.AddPart(CreateBody());

            Console.WriteLine($"Total price: {vehicle.CalculateTotal()}");

            var exit = false;
            do
            {                
                Console.WriteLine("Change part:");
                Console.WriteLine("1. Engine");
                Console.WriteLine("2. Body");
                Console.WriteLine("End");
                var chose = Console.ReadLine();
                switch (chose)
                {
                    case "1":
                        vehicle.Engine = CreateEngine();
                        vehicle.ReplacePart(CreateEngine());
                        break;
                    case "2":
                        vehicle.ReplacePart(CreateBody());
                        break;
                    default:
                        exit = true;
                        break;
                }

                Console.WriteLine($"New Price: {vehicle.CalculateTotal()}");

            } while (!exit);
        }

        static Engine CreateEngine()
        {
            while (true)
            {
                Console.WriteLine("Enter Engine Type:");
                Console.WriteLine("1. Deasel");
                Console.WriteLine("2. Petrol");
                var type = Console.ReadLine();

                Console.WriteLine("Enter price: ");
                switch (type)
                {
                    case "1":
                        return new Diesel(int.Parse(Console.ReadLine()));
                    case "2":
                        return new Petrol(int.Parse(Console.ReadLine()));
                    default:
                        Console.WriteLine("Enter valid type!");
                        break;
                }
            }
        }

        static VehicleBody CreateBody()
        {
            while (true)
            {
                Console.WriteLine("Enter Body Type:");
                Console.WriteLine("1. SUV");
                Console.WriteLine("2. Roadster");
                var type = Console.ReadLine();

                Console.WriteLine("Enter price: ");
                switch (type)
                {
                    case "1":
                        return new SUV(int.Parse(Console.ReadLine()));
                    case "2":
                        return new Roadster(int.Parse(Console.ReadLine()));
                    default:
                        Console.WriteLine("Enter valid type!");
                        break;
                }
            }
        }

    }
}
