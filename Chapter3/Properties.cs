using System;

namespace chapter_3
{
    class PropertiesExample
    {
        public int A { get; set; }
        public int B { get; set; }

        private float celsius;

        public float Fahrenheit
        {
            get { return (celsius * 9 / 5) + 32; }
            set { celsius = (value - 32) * 5 / 9; }
        }
    }

    class Properties
    {
        public static void Main()
        {
            PropertiesExample obj = new PropertiesExample();
            obj.Fahrenheit = 98.6f;
            float f = obj.Fahrenheit;
            Console.WriteLine($"Fahrenheit: {f}");
        }
    }
}