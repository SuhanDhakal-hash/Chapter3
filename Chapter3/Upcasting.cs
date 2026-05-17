using System;

namespace Chapter3
{
    public class BaseAnimal
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }


    public class DerivedDogClass : BaseAnimal
    {
        public void Run()
        {
            Console.WriteLine("Running");
        }
    }

    class Upcasting
    {
        public static void Main()
        {

            DerivedDogClass dogObj = new DerivedDogClass();

            BaseAnimal animalObj = dogObj;

            animalObj.Eat();

            DerivedDogClass d = (DerivedDogClass)animalObj;
            d.Run();
        }
    }
}