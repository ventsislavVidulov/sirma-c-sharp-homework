using System.Text;

namespace FileSystem.Tasks.Playground;
internal class Playground
{
    public string Name { get; } = "Playground";
    private static string inputRealtivePath = @"..\..\..\..\FileSystem\Tasks\Playground\input.txt";

    private MemoryStream memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(inputRealtivePath));

    public void Solve()
    {
        memoryStream.Position = 0;
        byte[] buffer = new byte[memoryStream.Length - 10];
        memoryStream.Read(buffer, 0, buffer.Length);
        Console.WriteLine($"Memory stream position: {memoryStream.Position}, Memory stream length: {memoryStream.Length}");
    }
}

