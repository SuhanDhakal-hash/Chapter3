using System;

namespace Chapter3
{
    class StaticExampleClass
    {
        static int count = 1;


        static StaticExampleClass()
        {

            Console.WriteLine("Static constructor called. Value of count: " + count);
            count++;
        }
    }

    class Static
    {
        static void Main()
        {
            StaticExampleClass obj1 = new StaticExampleClass();
            StaticExampleClass obj2 = new StaticExampleClass();
            StaticExampleClass obj3 = new StaticExampleClass();
        }
    }
}