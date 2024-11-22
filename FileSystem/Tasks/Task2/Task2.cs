namespace FileSystem.Tasks.Task2
{
    internal class Task2
    {
        public string Name { get; } = "Character Frequency";

        private StreamReader streamReader = new StreamReader("C:\\Users\\Xcen3\\Desktop\\Sirma\\C#\\SirmaCSharpHomework\\FileSystem\\Tasks\\Task2\\input.txt");

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
