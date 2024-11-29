using System.Linq;
using System.Text;

namespace FileSystem.Tasks.Task7
{
    internal class Task7
    {
        private static string inputRealtivePath = @"..\..\..\..\FileSystem\Tasks\Task7\input.txt";
        private static string ouputRealtivePath = @"..\..\..\..\FileSystem\Tasks\Task7\output.txt";
        public string Name { get; } = "nique words";
        public void Solve()
        {
            using (StreamReader sr = new StreamReader(inputRealtivePath))
            {
                string[] separators = { "\n", ". ", ".", " ", "\r\n", "!"};
                //Are the separators order of mather?
                HashSet<string> words = new HashSet<string>();
                string[] input = sr.ReadToEnd().Split(separators, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in input)
                {
                    words.Add(word);
                }
                Console.WriteLine(words.Count);
            }
        }
    }
}
