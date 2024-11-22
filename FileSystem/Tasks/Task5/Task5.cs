using System.Text;

namespace FileSystem.Tasks.Task5
{
    internal class Task5
    {
        private static string inputRealtivePath = @"..\..\..\..\FileSystem\Tasks\Task5\input.txt";
        private string fileName;
        private string fileExtension;
        private int fileByteSize;
        public string Name { get; } = "Extract File";
        public void Solve()
        {
            fileName = Path.GetFileNameWithoutExtension (inputRealtivePath);
            fileExtension = Path.GetExtension(inputRealtivePath);

            using (FileStream fileStram = new(inputRealtivePath, FileMode.Open, FileAccess.ReadWrite))
            {
                byte[] buffer = new byte[fileStram.Length];
                fileByteSize = fileStram.Read(buffer);
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
            Console.WriteLine($"File size: {fileByteSize} bytes");
        }
    }
}
