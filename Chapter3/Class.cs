using System;

namespace Chapter3
{
    public class Person
    {
        public string Name;
        public int Age;

        public void Introduction()
        {

            Console.WriteLine($"My name is {Name} and I am {Age} years old");
        }
    }

    class Class
    {
        static void Main()
        {

            Person person1 = new Person();
            person1.Name = "Suhan Dhakal";
            person1.Age = 25;
            person1.Introduction();
        }
    }
}