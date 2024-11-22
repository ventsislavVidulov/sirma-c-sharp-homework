using FileSystem.Tasks.Task1;
using FileSystem.Tasks.Task2;
using FileSystem.Tasks.Task3;

namespace FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var task1 = new Task1();
            var task2 = new Task2();
            var task3 = new Task3();
            task1.Solve();
            task2.Solve();
            task3.Solve();
        }
    }
}
