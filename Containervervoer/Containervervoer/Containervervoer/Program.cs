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
            List<CargoForShipping> Shipments = new List<CargoForShipping>();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Welcome to the container transport application");
                Console.WriteLine("1 - Create a ship");
                Console.WriteLine("2 - View ships");
                Console.WriteLine("3 - Create shipment");
                Console.WriteLine("4 - View shipment");
                Console.WriteLine("5 - Exit console");

                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        CreateShip(CargoShips);
                        Console.WriteLine();
                        break;

                    case ConsoleKey.D2:
                        OverviewShips(CargoShips, Shipments);
                        Console.WriteLine();
                        break;

                    case ConsoleKey.D3:
                        CreateShipment(Shipments);
                        Console.WriteLine();
                        break;

                    case ConsoleKey.D4:
                        OverviewShipments(Shipments);
                        Console.WriteLine();
                        break;

                    case ConsoleKey.D5:
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

                cargoShip.Storagegrid.GenerateStorageGrid();

                cargoShips.Add(cargoShip);

                break;
            }
        }

        static void OverviewShips(List<CargoShip> cargoShips, List<CargoForShipping> cargoForShippings)
        {
            while (true)
            {
                int counter = new int();

                Console.Clear();

                Console.WriteLine("List of availble ships");

                foreach (CargoShip cargoship in cargoShips)
                {
                    counter++;
                    Console.WriteLine(counter + " Ship: " + cargoship.ShipName);
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
                        Console.WriteLine("Give ship number");
                        SelectShip(cargoShips[Convert.ToInt32(Console.ReadLine()) - 1], cargoForShippings);
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

        static void SelectShip(CargoShip cargoShip, List<CargoForShipping> cargoForShippings) 
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("Ship name: " + cargoShip.ShipName);
           
                Console.WriteLine("");
                Console.WriteLine("1 - Load a shipment");
                Console.WriteLine("2 - ");
                Console.WriteLine("3 - Go back");

                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        foreach (CargoForShipping cargo in cargoForShippings)
                        {
                            Console.WriteLine("Shipment ID: " + cargo.ShipmentId);
                        }
                        Console.WriteLine("Give shipment ID");
                        cargoShip.LoadShipment(cargoForShippings[Convert.ToInt32(Console.ReadLine()) - 1]);

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

        static void CreateShipment(List<CargoForShipping> shipments)
        {
            while (true)
            {
                Console.Clear();
                shipments.Add(new CargoForShipping { ShipmentId = shipments.Count + 1 });
                SelectShipment(shipments[shipments.Count - 1]);
                break;
            }
        }

        static void OverviewShipments(List<CargoForShipping> shipments)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("List of availble shipments");

                foreach (CargoForShipping cargo in shipments)
                {
                    Console.WriteLine("Shipment ID: " + cargo.ShipmentId);
                }

                Console.WriteLine("");
                Console.WriteLine("1 - Select a shipment");
                Console.WriteLine("2 - Delete a shipment");
                Console.WriteLine("3 - Go back");

                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Console.WriteLine("Give shipment ID");
                        SelectShipment(shipments[Convert.ToInt32(Console.ReadLine())- 1]);
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

        static void SelectShipment(CargoForShipping shipment)
        {
            int type;
            int weight;

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Shipment ID: " + shipment.ShipmentId);
                Console.WriteLine("Current weight: " + shipment.GiveTotalWeight());
                Console.WriteLine("Total containers: " + shipment.GiveTotal());
                Console.WriteLine("Regular containers: " + shipment.GiveRegular());
                Console.WriteLine("Cooling containers: " + shipment.GiveCooled());
                Console.WriteLine("Valuable containers: " + shipment.GiveValuable());

                foreach (Container container in shipment.Containers)
                {
                    Console.WriteLine(container.ToString());
                }

                Console.WriteLine("");
                Console.WriteLine("1 - Add a container");
                Console.WriteLine("2 - Delete a container");
                Console.WriteLine("3 - Go back");

                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Console.WriteLine("What is the type? 1 = regular 2 = cooling 3 = valueable 4 = cooling and valuable");
                        type = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What is the weight? in kilo's");
                        weight = Convert.ToInt32(Console.ReadLine());
                        shipment.AddContainer(type, weight);
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

