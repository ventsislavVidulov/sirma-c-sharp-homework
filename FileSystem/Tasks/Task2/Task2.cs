namespace FileSystem.Tasks.Task2
{
    internal class Task2
    {
        public string Name { get; } = "Character Frequency";

        private StreamReader streamReader = new StreamReader("C:\\Users\\Xcen3\\Desktop\\Sirma\\C#\\SirmaCSharpHomework\\FileSystem\\Tasks\\Task1\\input.txt");

        public void Solve()
        {
            string characters = streamReader.ReadToEnd();
            streamReader.Close();
            foreach (var character in characters)
            {
                Console.WriteLine(character);
            }
        }
    }
}
