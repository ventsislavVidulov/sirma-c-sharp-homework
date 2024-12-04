namespace Polymrphism.Shapes
{
    internal class Rectangle : Shape
    {
        private readonly double width;
        private readonly double height;

        internal static int Parameters = 2;

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
