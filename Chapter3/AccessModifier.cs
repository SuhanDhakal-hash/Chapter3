using System;

namespace Chapter3
{
    public class ModifierExample
    {
        public string name;
        private int age;


        public ModifierExample(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public int GetAge()
        {
            return age;
        }
    }

    class AcessModifier
    {
        public static void Main()
        {
            ModifierExample obj = new ModifierExample("Suhan Dhakal", 30);

            Console.WriteLine($"Name: {obj.name}");
            Console.WriteLine($"Age: {obj.GetAge()}");
        }
    }
}