namespace OOPSconcepts.Abstraction
{
    public abstract class IShape
    {
        public abstract double Area();
    }

    public class Circle : IShape
    {
        private readonly double radius;

        /*public Circle() { }*/
        public Circle(double r)
        {
            radius = r;
        }

        public override double Area()
        {
            return 3.14 * radius * radius;
        }
    }

    public class Triangle : IShape
    {
        private readonly double tbase;
        private readonly double theight;

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

        /*public override double Area()
        {
            return side * side;
        }*/

        public double Area() =>
            side * side;
    }

    class Calculations
    {
        public void Main()
        {
            /*Circle circle = new(10);
            Console.WriteLine(circle.Area());

            Square square = new(15);
            Console.WriteLine(square.Area());

            Triangle triangle = new(20, 10);
            Console.WriteLine(triangle.Area());*/
        }
    }
}
