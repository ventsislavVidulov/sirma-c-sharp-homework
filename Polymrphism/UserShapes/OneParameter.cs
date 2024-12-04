using Polymrphism.Shapes;

namespace Polymrphism.UserShapes
{
    internal class OneParameter : Shape
    {
        private Func<double, double> AreaCalculator;
        private double inputs;

        internal static int Parameters = 1;
        public OneParameter(string name, Func<double, double> func, double inputs)
        {
            AreaCalculator = func;
            this.inputs = inputs;
            base.Name = name;
        }

        internal override double GetArea()
        {
            return AreaCalculator(inputs);
        }
    }
}
