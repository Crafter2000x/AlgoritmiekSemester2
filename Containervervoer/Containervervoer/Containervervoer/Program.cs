using System;
using Containervervoer.Classes;
using System.Collections.Generic;

namespace Containervervoer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CargoShip> CargoShips = new List<CargoShip>();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Welcome to the container transport application");
                Console.WriteLine("1 - Create a ship");
                Console.WriteLine("2 - View ships");
                Console.WriteLine("3 - Exit console");

                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        CreateShip(CargoShips);
                        Console.WriteLine();
                        break;

                    case ConsoleKey.D2:
                        OverviewShips(CargoShips);
                        Console.WriteLine();
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine();
                        return;

                    default:
                        break;
                }

            }
        }

        static void CreateShip(List<CargoShip> cargoShips) 
        {
            CargoShip cargoShip = new CargoShip();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Enter ship name");
                cargoShip.ShipName = Console.ReadLine();
                Console.WriteLine("Maximum containers width");
                cargoShip.Storagegrid.ContainerWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Maximum containers height");
                cargoShip.Storagegrid.ContainerHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Maximum containers stacking hight");
                cargoShip.Storagegrid.ContainerStack = Convert.ToInt32(Console.ReadLine());

                cargoShip.Storagegrid.GenerateStorageGrid();

                cargoShips.Add(cargoShip);

                break;
            }
        }

        static void OverviewShips(List<CargoShip> cargoShips)
        {
            CargoShip cargoShip = new CargoShip();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("List of availble ships");

                foreach (CargoShip cargoship in cargoShips)
                {
                    Console.WriteLine("Ship: " + cargoship.ShipName);
                }

                Console.WriteLine("");
                Console.WriteLine("1 - Select a ship");
                Console.WriteLine("2 - Delete a ship");
                Console.WriteLine("3 - Go back");

                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine();
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine();
                        return;

                    default:
                        break;
                }
            }
        }
    }
}

