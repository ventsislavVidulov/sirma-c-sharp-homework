using AbstractionAndEncapsulation.Interfaces;

namespace AbstractionAndEncapsulation.Classes
{
    internal abstract class Item : IItem, ICategorizable, IBreakable, IPerishable, ISellable
    {
        protected string _name = "Default name";
        protected double _value = 0;
        protected double _price = 0;
        protected string _description = "Default escription";
        protected string _category = "Default category";
        protected string _type = "Default type";
        protected bool _isBreakable = false;
        protected bool _isBroken = false;
        protected bool _isPerishable = false;
        protected bool _isExpired = false;
        protected string _details = "Default details";
        public virtual string Details => _details;
        public string Name => _name;
        public string Description => _description;
        public string Category
        {
            get => _category;
            set => _category = value;
        }
        public double Price { get => _price; set => _price = value; }
        public virtual double CalculateValue()
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
