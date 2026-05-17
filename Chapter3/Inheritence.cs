using System;

namespace Chapter3
{

    public class Vehicle
    {
        public string Model { get; set; }
        public int Speed { get; set; }

        public void Start()
        {
            Console.WriteLine("Vehicle started");
        }

        public void Drive()
        {
            Console.WriteLine($"Driving the {Model} at {Speed} km/h");
        }
    }


    public class Car : Vehicle
    {
        public void Honk()
        {
            Console.WriteLine("Car is honking");
        }
    }

    class Inheritance
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Model = "Toyota";
            myCar.Speed = 80;

            myCar.Start();
            myCar.Drive();
            myCar.Honk();
        }
    }
}