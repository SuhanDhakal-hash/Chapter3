using System;

namespace Chapter3
{
    class StaticConstructor
    {
        public string name;


        public StaticConstructor()
        {
            this.name = "Three Body Problem";
            Console.WriteLine($"Book name: {this.name}");
        }
    }

    class Constructors
    {
        static void Main()
        {
            Book bookObj = new Book();
        }
    }
}