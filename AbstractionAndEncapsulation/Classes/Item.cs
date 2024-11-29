using AbstractionAndEncapsulation.Interfaces;

namespace AbstractionAndEncapsulation.Classes
{
    internal abstract class Item : IItem, ICategorizable, IBreakable, IPerishable, ISellable
    {
        private string _name = "Default name";
        private string _details = "Default details";
        private double _value = 0;
        private double _price = 0;
        private string _description = "Default escription";
        private string _category = null;
        private bool _isBreakable = false;
        private bool _isBroken = false;
        private bool _isPerishable = false;
        private bool _isExpired = false;
        public string Details => _details;

        public string Description => _description;

        public string Category
        {
            get => _category;
            set => _category = value;
        }
        public double Price { get => _price; set => _price = value; }

        public double CalculateValue()
        {
            //???
            throw new NotImplementedException();
        }

        public bool CheckForBreakability()
        {
            return _isBreakable;
        }

        public bool CheckForPerishability()
        {
            return _isPerishable;
        }

        public void HandleItemBreakage()
        {
            if (_isBreakable && _isBroken)
            {
                _isBroken = false;
            }
        }

        public void HandleItemExpiration()
        {
            //???
            throw new NotImplementedException();
        }
    }
}
