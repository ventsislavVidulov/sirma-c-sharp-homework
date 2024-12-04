namespace Polymrphism.Shapes
{
    internal class Circle : Shape
    {
        private double radius;

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