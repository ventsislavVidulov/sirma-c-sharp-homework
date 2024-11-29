using AbstractionAndEncapsulation.Classes;

namespace AbstractionAndEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vase = new Item();

            Console.WriteLine(vase.ItemDescription());
        }
    }
}
