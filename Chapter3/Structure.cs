using System;

namespace Chapter3
{
    public struct Point
    {
        public int X;
        public int Y;

     
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        
        public void Print()
        {
            Console.WriteLine($"Point: ({X}, {Y})");
        }

        
        public double DistanceFromOrigin()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }

    internal class Structure
    {
        static void Main()
        {
           
            Point p1 = new Point(3, 4);
            Point p2 = new Point(4, 5);

           
            p1.Print();
            p2.Print();

           
            Console.WriteLine($"Distance of p1 from origin: {p1.DistanceFromOrigin()}");
            Console.WriteLine($"Distance of p2 from origin: {p2.DistanceFromOrigin()}");

            
            Point a = new Point(3, 4);
            Point b = a;

            
            b.X = 99;

            
            Console.WriteLine($"A.X = {a.X}");
            Console.WriteLine($"B.X = {b.X}");
        }
    }
}