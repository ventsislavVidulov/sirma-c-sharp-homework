namespace Polymrphism.Shapes
{
    internal class Rectangle : Shape
    {
        private readonly double width;
        private readonly double height;
        internal string Name { get; set; }

        internal Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
            base.Name = this.GetType().Name;
        }

        internal override double GetArea()
        {
            return width * height;
        }
    }
}
