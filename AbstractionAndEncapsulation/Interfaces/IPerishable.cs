namespace AbstractionAndEncapsulation.Interfaces
{
    internal interface IPerishable
    {
        bool CheckForPerishability();
        void HandleItemExpiration();
    }
}
