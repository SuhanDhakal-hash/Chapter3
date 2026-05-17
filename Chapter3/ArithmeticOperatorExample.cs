using System;

namespace Chapter3
{
    class Student1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Marks { get; set; }
    }

    class ArithmeticOperatorExample
    {
        static void Main(string[] args)
        {

            Student1 s1 = new Student1()
            {
                Id = 1,
                Name = "Ram",
                FirstName = "Ram",
                LastName = "Sharma",
                Marks = 80
            };


            Student1 s2 = new Student1()
            {
                Id = 2,
                Name = "Shyam",
                FirstName = "Shyam",
                LastName = "Karki",
                Marks = 60
            };


            int add = s1.Marks + s2.Marks;
            int sub = s1.Marks - s2.Marks;
            int mul = s1.Marks * s2.Marks;

            double div;
            if (s2.Marks != 0)
                div = (double)s1.Marks / s2.Marks;
            else
                div = 0;


            Console.WriteLine("Student 1: " + s1.Name + " Marks: " + s1.Marks);
            Console.WriteLine("Student 2: " + s2.Name + " Marks: " + s2.Marks);

            Console.WriteLine("\nArithmetic Operations:");
            Console.WriteLine("Addition (+): " + add);
            Console.WriteLine("Subtraction (-): " + sub);
            Console.WriteLine("Multiplication (*): " + mul);
            Console.WriteLine("Division (/): " + div);

            Console.ReadLine();
        }
    }
}