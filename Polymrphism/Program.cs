using Polymrphism.Shapes;

namespace Polymrphism
{
    class Program
    { 
        static void Main(string[] args)
        {
            //string squareAreaFunction = "x => x * x";

            //var str = "f => f.Substring(0, f.IndexOf(' '))";
            //var func = await CSharpScript.EvaluateAsync<Func<string, string>>(str);
            //var firstWord = func("Hello World");


            List<Shape> shapes = new List<Shape>()
            {
                new Circle(5),
                new Rectangle(4, 6),
                new UserShape("Square", x => x * x, 5 )
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine($"The area of the {shape.Name} is {shape.GetArea():F2}");
            }

            //var delPlay = new DelegatesPlayDround();
            //Console.WriteLine(delPlay.Diff(5, x => x * 5));
        }
    }
}
