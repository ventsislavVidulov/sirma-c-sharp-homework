namespace AbstractionAndEncapsulation.Interfaces
{
    internal interface IItem
    {
        string Details { get; }
        string Description { get; }
        double CalculateValue();
    }
}
