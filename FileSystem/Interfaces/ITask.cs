namespace FileSystem.Interfaces
{
    internal interface ITask
    {
        string Name { get; }
        string Solve();
    }
}
