namespace AbstractionAndEncapsulation.Classes
{
    internal class InventoryItem : Item
    {
        public int Id { get; set; }
        public int Quantity { get; set; }

        public override string Details
        {
            get
            {
                return $"{Id + 1}. {Name}, a {Description} of category {Category} with price {Price}, quantity {Quantity} and type {_type}";
            }
        }
        //name, category, price, quantity, and item type.
        public InventoryItem(string name, string category, double price, int quantity, string type, int id, string description ) : base()
        {
            _name = name;
            _category = category;
            _price = price;
            this.Quantity = quantity;
            this.Id = id;
            _type = type;
            _description = description;
        }

        public override double CalculateValue()
        {
            return _price * Quantity;
        }
    }
}
