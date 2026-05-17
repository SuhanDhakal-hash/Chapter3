using System;

namespace Chapter3

{
    class ChainConstructor
    {
        public string Name;
        public int Age;
        public string Address;


        public ChainConstructor(string name, int age, string address)
        {
            Name = name;
            Age = age;
            Address = address;

            Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}");
        }


        public ChainConstructor(string name, int age) : this(name, age, "Unknown")
        {
            Console.WriteLine("Constructor with two parameters called");
        }


        public ChainConstructor(string name) : this(name, 10)
        {
            Console.WriteLine("Single parameter constructor called");
        }
    }

    class Chain
    {
        static void Main()
        {
            ChainConstructor obj1 = new ChainConstructor("Poshan", 25, "Nepal");
            ChainConstructor obj2 = new ChainConstructor("Suhan", 35, "UK");
            ChainConstructor obj3 = new ChainConstructor("Sita", 40, "USA");
        }
    }
}