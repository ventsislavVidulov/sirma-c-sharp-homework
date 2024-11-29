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
    }
}
