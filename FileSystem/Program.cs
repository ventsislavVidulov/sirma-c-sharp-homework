using FileSystem.Tasks.Task1;
using FileSystem.Tasks.Task2;

namespace FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var task1 = new Task1();
            var task2 = new Task2();
            Console.WriteLine(task1.Solve());
            task2.Solve();
        }
    }
}
