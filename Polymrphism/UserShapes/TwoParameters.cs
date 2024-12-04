using Polymrphism.Shapes;

namespace Polymrphism.UserShapes
{
    internal class TwoParameters : Shape
    {
        private Func<double, double, double> AreaCalculator;
        private double inputOne;
        private double inputTwo;

        internal static int Parameters = 2;
        public TwoParameters(string name, Func<double, double, double> func, double inputOne, double inputTwo) 
        {
            AreaCalculator = func;
            this.inputOne = inputOne;
            this.inputTwo = inputTwo;
            base.Name = name;
        }

        internal override double GetArea()
        {
            return AreaCalculator(inputOne, inputTwo);
        }
    }
}
