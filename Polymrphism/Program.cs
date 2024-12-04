using Polymrphism.Shapes;
using Polymrphism.UserShapes;
using Polymrphism.Utils;

namespace Polymrphism
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string command = "start";
            string shapeName = "shape";
            string areaFormula = "42";
            int paramsNumber = 0;
            double paramOne = 0;
            double paramTwo = 0;
            double paramThree = 0;

            string squareAreaFunctionString = "x => x * x";
            string rectangleAreaFunctionString = "(x, y) => x * y";

            var funcSquare = Utils.StringToFunctionParser.OneParameterAsync(squareAreaFunctionString);
            var funcRectangle = Utils.StringToFunctionParser.TwoParametersAsync(rectangleAreaFunctionString);


            List<Shape> shapes = new List<Shape>()
            {
                new Circle(5),
                new Rectangle(4, 6),
                new OneParameter("Square", funcSquare.Result, 5 ),
                new TwoParameters("Rectangle", funcRectangle.Result, 6, 7)
            };

            while (command != "end")
            {
                Console.WriteLine("Choose command \n'square', \n'circle', \n'triangle' \n'list' to list all created figures" +
                    "\n'red pill' if you are brave enough to create your own shape \n'end' to end :)");
                command = Console.ReadLine();

                if (command == "red pill" || (command != "list" && command != "end"))
                {
                    if (command == "red pill")
                    {
                        Console.WriteLine("Hi there, brave stranger, how many params accepts your shape area formula (1, 2 or 3)");
                    }
                    else
                    {
                        Console.WriteLine("Nah, only red pills for now, we are still under construction, so how many params accepts your shape area formula (1, 2 or 3)");
                    }

                    paramsNumber = Convert.ToInt32(Console.ReadLine());

                    if (paramsNumber == 1)
                    {
                        Console.WriteLine("OK, OK, now enter the formula to calculate the shape area in the format 'x => x * x', you may also use the Math. library");
                        areaFormula = Console.ReadLine();
                        Console.WriteLine("Please, enter the parameter");
                        paramOne = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("We are almoust there, just enter a name for your shape");
                        shapeName = Console.ReadLine();

                        OneParameter tempShape = new OneParameter(shapeName, StringToFunctionParser.OneParameterAsync(areaFormula).Result, paramOne);

                        Console.WriteLine($"Congratulations you created a shape {tempShape.Name} with area {tempShape.GetArea():F2}");
                        shapes.Add(tempShape);
                    }
                    else if (paramsNumber == 2)
                    {
                        Console.WriteLine("OK, OK, now enter the formula to calculate the shape area in the format '(x, y) => x * y', you may also use the Math. library");
                        areaFormula = Console.ReadLine();
                        Console.WriteLine("Please, enter the first parameter");
                        paramOne = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please, enter the second parameter");
                        paramTwo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("We are almoust there, just enter a name for your shape");
                        shapeName = Console.ReadLine();

                        TwoParameters tempShape = new TwoParameters(shapeName, StringToFunctionParser.TwoParametersAsync(areaFormula).Result, paramOne, paramTwo);

                        Console.WriteLine($"Congratulations you created a shape {tempShape.Name} with area {tempShape.GetArea():F2}");
                        shapes.Add(tempShape);
                    }
                    else if (paramsNumber == 3)
                    {
                        Console.WriteLine("OK, OK, now enter the formula to calculate the shape area in the format '(a, b, h) => 0.5 * (a + b) * h', you may also use the Math. library");
                        areaFormula = Console.ReadLine();
                        Console.WriteLine("Please, enter the first parameter");
                        paramOne = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please, enter the second parameter");
                        paramTwo = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please, enter the third parameter");
                        paramThree = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("We are almoust there, just enter a name for your shape");
                        shapeName = Console.ReadLine();

                        ThreeParameters tempShape = new ThreeParameters(shapeName, StringToFunctionParser.ThreeParametersAsync(areaFormula).Result, paramOne, paramTwo, paramThree);

                        Console.WriteLine($"Congratulations you created a shape {tempShape.Name} with area {tempShape.GetArea():F2}");
                        shapes.Add(tempShape);
                    }
                }
                else if (command == "end")
                {
                    return;
                }
                else if (command == "list")
                {
                    foreach (Shape shape in shapes)
                    {
                        Console.WriteLine($"The area of the {shape.Name} is {shape.GetArea():F2}");
                    }
                }
            }



        }
    }
}
