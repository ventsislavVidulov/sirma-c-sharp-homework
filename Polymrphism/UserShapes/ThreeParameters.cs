using Polymrphism.Shapes;

namespace Polymrphism.UserShapes
{
    internal class ThreeParameters : Shape
    {
        private Func<double, double, double, double> AreaCalculator;
        private double inputOne;
        private double inputTwo;
        private double inputThree;

        internal static int Parameters = 3;
        public ThreeParameters(string name, Func<double, double, double, double> func, double inputOne, double inputTwo, double inputThree) 
        {
            AreaCalculator = func;
            this.inputOne = inputOne;
            this.inputTwo = inputTwo;
            this.inputThree = inputThree;
            base.Name = name;
        }

        internal override double GetArea()
        {
            return AreaCalculator(inputOne, inputTwo, inputThree);
        }
    }
}
