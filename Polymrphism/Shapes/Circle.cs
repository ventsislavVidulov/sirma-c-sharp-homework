namespace Polymrphism.Shapes
{
    internal class Circle : Shape
    {
        private double radius;

        internal static int Parameters = 1;

        internal Circle(double radius)
        {
            this.radius = radius;
            base.Name = this.GetType().Name;
        }

        internal override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}