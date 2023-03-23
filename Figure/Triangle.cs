namespace Figure
{
    public class Triangle : IFigure
    {
        private double _sizeA;
        private double _sizeB;
        private double _sizeC;

        public Triangle(double sizeA, double sizeB, double sizeC)
        {
            if ((sizeA + sizeB > sizeC) && (sizeB + sizeC > sizeA) && (sizeA + sizeC) > sizeB)
            {
                _sizeA = sizeA;
                _sizeB = sizeB;
                _sizeC = sizeC;
            }
            else
            {
                throw new ArgumentException("Треугольника с такими сторонами не существует");
            }
        }

        public double GetSquare()
        {
            var p = (_sizeA + _sizeB + _sizeC) / 2.0;

            return Math.Sqrt(p * (p - _sizeA) * (p - _sizeB) * (p - _sizeC));
        }

        public bool IsRightAngled()
        {
            var sides = new double[] { _sizeA, _sizeB, _sizeC };

            Array.Sort(sides);

            return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }
    }
}
