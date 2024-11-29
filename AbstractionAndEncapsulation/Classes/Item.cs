using AbstractionAndEncapsulation.Interfaces;

namespace AbstractionAndEncapsulation.Classes
{
    internal class Item
    {
        private string _description;

        public Item() { }
        public Item(string description) 
        { 
            this._description = description;
        }

        public string ItemDescription()
        {
            return this._description;
        }
    }
}
