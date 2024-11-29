using AbstractionAndEncapsulation.Classes;
using System.Reflection;
using System.Text;

namespace AbstractionAndEncapsulation.Helpers
{
    internal static class Helper
    {
        private static string DBRealtivePath = @"..\..\..\..\AbstractionAndEncapsulation\DB\DB.txt";
        public static void SafeToFile(InventoryItem item)
        {
            using (StreamWriter sw = new StreamWriter(DBRealtivePath, append: true))
            {
                List<string> list = new List<string>();
                Type type = item.GetType();

                PropertyInfo[] properties = type.GetProperties();

                foreach (PropertyInfo property in properties)
                {
                    // Get the name and value of each property
                    string propertyName = property.Name;
                    object propertyValue = property.GetValue(item);

                    if (propertyName != "Details")
                    {
                        list.Add($"{property.Name}->{propertyValue}");
                    }
                }
                sw.WriteLine(string.Join("; ", list));
            }
        }

        public static List<InventoryItem> ReadFromFile()
        {
            using (StreamReader sr = new StreamReader(DBRealtivePath))
            {
                List<InventoryItem> list = new List<InventoryItem>();
                string stream = sr.ReadToEnd();
                if (stream.Length > 0)
                {
                    Console.WriteLine("We have some saved items, now we will load it.");

                    string[] items = stream.Split("\n");

                    foreach (var item in items)
                    {
                        if (item.Length > 0)
                        {
                            string[] tuples = item.Split("; ");

                            //name, category, price, quantity, and item type.
                            int id = 0;
                            string name = "Not initialized name";
                            string category = "Not initialized category";
                            double price = 0;
                            int quantity = 0;
                            string type = "Not initialized type";
                            string description = "Not initialized escription";

                            foreach (var tuple in tuples)
                            {
                                string[] splitedTuple = tuple.Split("->");
                                string key = splitedTuple[0];
                                string value = splitedTuple[1];

                                if (key == "Id")
                                {
                                    id = int.Parse(value);
                                }
                                else if (key == "Name")
                                {
                                    name = value;
                                }
                                else if (key == "Category")
                                {
                                    category = value;
                                }
                                else if (key == "Price")
                                {
                                    price = double.Parse(value);
                                }
                                else if (key == "Quantity")
                                {
                                    quantity = int.Parse(value);
                                }
                                else if (key == "Type")
                                {
                                    type = value;
                                }
                                else if (key == "Description")
                                {
                                    description = value;
                                }
                            }
                            list.Add(new InventoryItem(name, category, price, quantity, type, id, description));
                        }
                    }
                }
                return list;
            }
        }
    }
}
