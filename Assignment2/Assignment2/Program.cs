using System;
using System.Collections.Generic;

namespace OrderingSystem
{
    class Program
    {
        static List<(string name, double price)> orders = new List<(string, double)>();

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nOrdering System Menu:");
                Console.WriteLine("1. Add new item");
                Console.WriteLine("2. View order summary");
                Console.WriteLine("3. Place order");
                Console.WriteLine("4. Total price of order");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddNewItem();
                        break;
                    case "2":
                        ViewOrderSummary();
                        break;
                    case "3":
                        PlaceOrder();
                        break;
                    case "4":
                        CalculateTotalPrice();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }

        static void AddNewItem()
        {
            Console.Write("Enter item name: ");
            string name = Console.ReadLine();

            Console.Write("Enter item price: ");
            double price = double.Parse(Console.ReadLine());

            orders.Add((name, price));
            Console.WriteLine("Item added successfully.");
        }

        static void ViewOrderSummary()
        {
            if (orders.Count == 0)
            {
                Console.WriteLine("No items in the order.");
            }
            else
            {
                Console.WriteLine("Order Summary:");
                foreach (var order in orders)
                {
                    Console.WriteLine($"Item: {order.name}, Price: {order.price:C}");
                }
            }
        }

        static void PlaceOrder()
        {
            if (orders.Count == 0)
            {
                Console.WriteLine("No items to place order.");
            }
            else
            {
                Console.WriteLine("Order placed successfully.");
                orders.Clear();
            }
        }

        static void CalculateTotalPrice()
        {
            double total = 0;
            foreach (var order in orders)
            {
                total += order.price;
            }
            Console.WriteLine($"Total price of order: {total:C}");
        }
    }
}