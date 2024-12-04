namespace Polymrphism.Shapes
{
    internal abstract class Shape
    {
        internal string Name { get; set; }

        internal abstract double GetArea();
    }
}