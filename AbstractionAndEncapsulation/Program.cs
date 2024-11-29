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

            items.Add(new InventoryItem("Test Name", "Test category", 1.20, 10, "Test type", id++));
            Helper.SafeToFile(items.LastOrDefault());
            items.Add(new InventoryItem("Test2 Name", "Test2 category", 1.30, 20, "Test2 type", id++));
            Helper.SafeToFile(items.LastOrDefault());

            Console.WriteLine("Choose command from add, end");
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
                    //name, category, price, quantity, and item type.
                    items.Add(new InventoryItem(name, category, price, quantity, itemType, id++));
                    Helper.SafeToFile(items.LastOrDefault());
                    Console.WriteLine($"Successfully added {items.LastOrDefault().Details}");
                }

                Console.WriteLine("Choose command from add, end");
                command = Console.ReadLine();
            }
        }
    }
}
