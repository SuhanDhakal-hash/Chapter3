using System;

namespace Chapter3
{

    public class AnimalClass
    {
        public void Speak()
        {
            Console.WriteLine("Animal speaks");
        }
    }


    public class DogClass : AnimalClass
    {
        public void Bark()
        {
            Console.WriteLine("Dog barks");
        }
    }

    class Downcasting
    {
        public static void Main()
        {

            AnimalClass animalObj = new DogClass();

            animalObj.Speak();


            DogClass dogObj = animalObj as DogClass;

            if (dogObj != null)
            {
                dogObj.Bark();
            }
            else
            {
                Console.WriteLine("Cast was not successful");
            }
        }
    }
}