using System;
namespace Chapter3
{
    public abstract class ShapeClass
    {
        public abstract double GetArea();
        public abstract double Perimeter();
        public void Display()
        {
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Perimeter: {Perimeter()}");
        }
    }


    public class Circleclass : ShapeClass
    {
        private double radius;

        public Circleclass(double r)
        {
            radius = r;
        }

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }
    }


    public class Rectangleclass : ShapeClass
    {
        private double length;
        private double breadth;

        public Rectangleclass(double l, double b)
        {
            length = l;
            breadth = b;
        }

        public override double GetArea()
        {
            return length * breadth;
        }

        public override double Perimeter()
        {
            return 2 * (length + breadth);
        }
    }

    internal class Abstraction
    {
        static void Main(string[] args)
        {

            Circleclass c = new Circleclass(5);
            Console.WriteLine("Circle:");
            c.Display();

            Console.WriteLine();


            Rectangleclass r = new Rectangleclass(4, 3);
            Console.WriteLine("Rectangle:");
            r.Display();

            Console.ReadLine();
        }
    }
}