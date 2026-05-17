using System;
namespace chapter_3
{
    interface IAnimal
    {
        void Speak();
    }

    class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine(" Dog Says Woof");
        }
    }

    class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine(" Cat Says Meow");
        }
    }


    class InterfaceExample
    {
        static void Main()
        {
            IAnimal dog = new Dog();
            IAnimal cat = new Cat();

            dog.Speak();
            cat.Speak();
        }
    }
}