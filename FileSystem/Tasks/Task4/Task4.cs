using System.Text;

namespace FileSystem.Tasks.Task4
{
    internal class Task4
    {
        public string Name { get; } = "Count Lines, Words, and Characters";
        private static string inputRealtivePath = @"..\..\..\..\FileSystem\Tasks\Task4\input.txt";

        private StreamReader streamReader = new StreamReader(inputRealtivePath);

        public void Solve()
        {
            string streamLine = streamReader.ReadLine();
            int linesCount = 0;
            int wordCout = 0;
            int charCount = 0;

            if (streamLine != null)
            {
                linesCount++;
            }

            while (streamLine != null)
            {
                linesCount++;
                wordCout += streamLine.Split(" ").Length;
                charCount += streamLine.Length;
                streamLine = streamReader.ReadLine();
            }

            Console.WriteLine($"Lines: {linesCount}, words: {wordCout}, charachters: {charCount}");
        }
    }
}
