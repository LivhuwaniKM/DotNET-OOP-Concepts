namespace OOPSconcepts.Abstraction
{
    public class Abstraction
    {
        public string Main()
        {
            Circle circle = new(17);
            Triangle triangle = new(10, 20);
            Square square = new(13);

            string output =
                $"==========================================\n" +
                $"Abstraction Demo\n" +
                $"==========================================\n" +
                $"Calculation for circle: {Math.Round(circle.Area(), 2)} meters\n" +
                $"Calculation for triangle: {triangle.Area()} centimeters\n" +
                $"Calculation fro square: {square.Area()} millimeters";

            return output;
        }
    }

    public abstract class IShape
    {
        public abstract double Area();
    }

    public class Circle : IShape
    {
        private readonly double radius;

        public Circle(double r)
        {
            radius = r;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Triangle : IShape
    {
        private readonly double tbase, theight;

        public Triangle(double b, double h)
        {
            tbase = b;
            theight = h;
        }

        public override double Area()
        {
            return 0.5 * tbase * theight;
        }
    }

    public class Square : IShape
    {
        private readonly double side;

        public Square(double s)
        {
            side = s;
        }

        public override double Area()
        {
            return side * side;
        }
    }
}
