namespace FileSystem.Tasks.Task1
{
    internal class Task1
    {
        public string Name { get; } = "Word Lengths";

        private StreamReader streamReader = new StreamReader("C:\\Users\\Xcen3\\Desktop\\Sirma\\C#\\SirmaCSharpHomework\\FileSystem\\Tasks\\Task1\\input.txt");

        public void Solve()
        {
            string output = String.Join(", ", streamReader.ReadToEnd().Split(" ").Select(w => w.Length));
            streamReader.Close();

            Console.WriteLine(output); 
        }
    }
}
