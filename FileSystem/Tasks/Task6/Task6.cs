using System.Linq;
using System.Text;

namespace FileSystem.Tasks.Task6
{
    internal class Task6
    {
        private static string inputRealtivePath = @"..\..\..\..\FileSystem\Tasks\Task6\input.txt";
        private static string otputRealtivePath = @"..\..\..\..\FileSystem\Tasks\Task6\output.txt";
        public string Name { get; } = "Reverse Lines";
        public void Solve()
        {
            using (StreamReader sr = new StreamReader(inputRealtivePath))
            {
                string[] readedText = sr.ReadToEnd().Split("\n");
                foreach (var line in readedText)
                {
                    char[] lineAsChars = line.ToCharArray();
                    Array.Reverse(lineAsChars);
                    Console.WriteLine(new String(lineAsChars));
                }
            }
        }
    }
}
