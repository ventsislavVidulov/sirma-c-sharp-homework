using System.Linq;
using System.Text;

namespace FileSystem.Tasks.Task6
{
    internal class Task6
    {
        private static string inputRealtivePath = @"..\..\..\..\FileSystem\Tasks\Task6\input.txt";
        private static string ouputRealtivePath = @"..\..\..\..\FileSystem\Tasks\Task6\output.txt";
        private List<string> output = new();
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
                    output.Add(new String(lineAsChars));
                }
            }

            using (StreamWriter sw = new StreamWriter(ouputRealtivePath))
            {
                sw.WriteLine(String.Join("\n", output));
            }
        }
    }
}
