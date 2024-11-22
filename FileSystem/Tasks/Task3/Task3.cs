using System.Text;

namespace FileSystem.Tasks.Task3
{
    internal class Task3
    {
        public string Name { get; } = "Character Frequency";

        private StreamReader streamReader = new StreamReader("C:\\Users\\Xcen3\\Desktop\\Sirma\\C#\\SirmaCSharpHomework\\FileSystem\\Tasks\\Task3\\input.txt");

        public void Solve()
        {
            string streamLine = streamReader.ReadLine();
            string targetWord = streamLine.Split(" -> ")[0];
            string newWord = streamLine.Split(" -> ")[1];

            streamLine = streamReader.ReadLine();
            string output = streamLine.Replace(targetWord, newWord);

            using (var fs = new FileStream("C:\\Users\\Xcen3\\Desktop\\Sirma\\C#\\SirmaCSharpHomework\\FileSystem\\Tasks\\Task3\\output.txt", FileMode.Create))
            {
                byte[] buffer = Encoding.UTF8.GetBytes(output);
                fs.Write(buffer, 0, output.Length);
            }
        }
    }
}
