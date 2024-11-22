namespace FileSystem.Tasks.Task2
{
    internal class Task2
    {
        public string Name { get; } = "Character Frequency";
        private static string inputRealtivePath = @"..\..\..\..\FileSystem\Tasks\Task2\input.txt";

        private StreamReader streamReader = new StreamReader(inputRealtivePath);

        public void Solve()
        {
            //string characters = streamReader.ReadToEnd();
            //streamReader.Close();
            //foreach (var character in characters)
            //{
            //    Console.WriteLine(character);
            //}

            char[] buffer = new char[1];
            int bytesRead;

            while ((bytesRead = streamReader.Read(buffer, 0, buffer.Length)) > 0)
            {
                Console.WriteLine(buffer);
            }
        }
    }
}
