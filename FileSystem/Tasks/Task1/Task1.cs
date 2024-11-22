namespace FileSystem.Tasks.Task1
{
    internal class Task1
    {
        public string Name { get; } = "Word Lengths";
        private static string inputRealtivePath = @"..\..\..\..\FileSystem\Tasks\Task1\input.txt";

        private StreamReader streamReader = new StreamReader(inputRealtivePath);

        public void Solve()
        {
            string output = String.Join(", ", streamReader.ReadToEnd().Split(" ").Select(w => w.Length));
            streamReader.Close();

            Console.WriteLine(output); 
        }
    }
}
