﻿using AbstractionAndEncapsulation.Classes;

namespace AbstractionAndEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            List<InventoryItem> items = new List<InventoryItem>();

            items.Add(new InventoryItem("Test Name", "Test category", 1.20, 10, "Test type", id++));
            Console.WriteLine(items[0].Details);
            Console.WriteLine(items[0].Id);
            Console.WriteLine("Choose command from <add>, ");
            string command = Console.ReadLine();

            if (command == "add") 
            {
                Console.WriteLine("Enter item name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter item category");
                string details = Console.ReadLine();
                Console.WriteLine("Enter item price");
                double value = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter item quantity");
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter item type");
                string type = Console.ReadLine();
                //name, category, price, quantity, and item type.
            }
        }
    }
}
