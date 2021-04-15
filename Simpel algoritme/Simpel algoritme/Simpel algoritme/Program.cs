using System;
using System.Collections.Generic;
using Simpel_algoritme.Classes;

namespace Simpel_algoritme
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Order> AllOrders = new List<Order>();

            while (true)
            {
                Console.Clear();

                Console.WriteLine("Welcome to the order overview");
                Console.WriteLine("1 - Create a order");
                Console.WriteLine("2 - Edit a order");
                Console.WriteLine("3 - Exit console");

                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        AllOrders.Add(new Order());
                        OrderEdit(AllOrders[AllOrders.Count - 1]);
                        break;

                    case ConsoleKey.D2:
                        OrderOverview(AllOrders);
                        Console.WriteLine();
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine();
                        return;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Unknown Command.");
                        break;
                }

            }
        }

        static void OrderOverview(List<Order> AllOrders)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("All orders: ");
                foreach (Order order in AllOrders)
                {
                    int i = AllOrders.IndexOf(order) + 1;
                    Console.WriteLine("Order " + i.ToString()); ;
                }

                Console.WriteLine("1 - Select a order");
                Console.WriteLine("2 - Delete a order");
                Console.WriteLine("3 - Back to the overview");

                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Console.WriteLine("What is the order number:");
                        OrderEdit(AllOrders[Convert.ToInt32(Console.ReadLine()) - 1]);
                        break;

                    case ConsoleKey.D2:
                        //Hahaha ooit een keer doen ofzo
                        Console.WriteLine();
                        break;

                    case ConsoleKey.D3:
                        Console.WriteLine();
                        return;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Unknown Command.");
                        break;
                }
            }
        }

        static void OrderEdit(Order Order) 
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Order: ");
                foreach (Product product in Order.ProductsInOrder)
                {
                    Console.WriteLine(product.ToString());
                }
                Console.WriteLine("Most expensive product: " + Order.GiveMaximumPrice().ToString());
                Console.WriteLine("Average price: " + Order.GiveAveragePrice().ToString());

                Console.WriteLine();
                Console.WriteLine("1 - Add product");
                Console.WriteLine("2 - Delete product");
                Console.WriteLine("3 - Sort order");
                Console.WriteLine("4 - Back to the overview");

                var input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.D1:
                        Product product = new Product();
                        Console.WriteLine();
                        Console.WriteLine("What is the product name:");
                        product.Name = Console.ReadLine();
                        Console.WriteLine("What is the product price:");
                        product.Price = Convert.ToDouble(Console.ReadLine());
                        Order.ProductsInOrder.Add(product);
                        break;

                    case ConsoleKey.D2:
                        //Hahaha ooit een keer doen ofzo
                        Console.WriteLine();
                        break;

                    case ConsoleKey.D3:
                        Order.SortProductsByPrice();
                        Console.WriteLine();
                        break;

                    case ConsoleKey.D4:
                        Console.WriteLine();
                        return;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Unknown Command.");
                        break;
                }
            }        
        }

    }
}
