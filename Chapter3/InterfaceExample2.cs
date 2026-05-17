using System;
namespace chapter_3
{
    interface IShape
    {
        double Area();
    }
    class Circle : IShape
    {
        public double Radius { get; set; }
        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
    class InterfaceExample2
    {
        static void Main(string[] args)
        {
            IShape shape = new Circle { Radius = 6 };
            Console.WriteLine($"Area of the circle: {shape.Area()}");
        }
    }
}