using FileSystem.Tasks.Playground;
using FileSystem.Tasks.Task1;
using FileSystem.Tasks.Task2;
using FileSystem.Tasks.Task3;
using FileSystem.Tasks.Task4;
using FileSystem.Tasks.Task5;
using FileSystem.Tasks.Task6;


namespace FileSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var playground = new Playground();
            var task1 = new Task1();
            var task2 = new Task2();
            var task3 = new Task3();
            var task4 = new Task4();
            var task5 = new Task5();
            var task6 = new Task6();

            task1.Solve();
            task2.Solve();
            task3.Solve();
            task4.Solve();
            task5.Solve();
            task6.Solve();
        }
    }
}
