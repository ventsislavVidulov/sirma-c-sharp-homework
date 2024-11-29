using AbstractionAndEncapsulation.Classes;
using AbstractionAndEncapsulation.Helpers;

namespace AbstractionAndEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            List<InventoryItem> items = new List<InventoryItem>();

            items = Helper.ReadFromFile();
            id = items.Count;

            Console.WriteLine("Choose command from add, list, end");
            string command = Console.ReadLine();

            while (command != "end")
            {
                if (command == "add")
                {
                    Console.WriteLine("Enter item name");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter item category");
                    string category = Console.ReadLine();
                    Console.WriteLine("Enter item price");
                    double price = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter item quantity");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter item type between electronic, grocery, or fragile");
                    string itemType = Console.ReadLine();
                    Console.WriteLine("Enter description");
                    string description = Console.ReadLine();
                    //name, category, price, quantity, and item type.
                    items.Add(new InventoryItem(name, category, price, quantity, itemType, id++, description));
                    Helper.SafeToFile(items.LastOrDefault());
                    Console.WriteLine($"Successfully added {items.LastOrDefault().Details}");
                    Console.WriteLine();
                }
                else if (command == "list")
                {
                    Console.WriteLine();
                    foreach (var item in items)
                    {
                        Console.WriteLine(item.Details);
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Choose command from add, list, end");
                command = Console.ReadLine();
            }
        }
    }
}
