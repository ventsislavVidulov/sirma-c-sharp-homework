namespace Polymrphism.Shapes
{
    internal class UserShape : Shape
    {
        private Func<double, double> AreaCalculator;
        private double input;
        internal string Name { get; set; }
        public UserShape(string name, Func<double, double> func, double input) 
        {
            AreaCalculator = func;
            this.input = input;
            base.Name = name;
        }

        internal override double GetArea()
        {
            return AreaCalculator(input);
        }
    }
}
