using Figure;

namespace TaskMindbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Triangle(2, 3, 4);

            Console.WriteLine(GetSquare(triangle));
        }

        public static double GetSquare(IFigure figure)
        {
            return figure.GetSquare();
        }
    }
}