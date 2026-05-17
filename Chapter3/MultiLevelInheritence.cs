using System;

namespace chapter_3
{
    class Employee
    {
        public string name;
        public double salary;

        public void DisplayEmployee()
        {
            Console.WriteLine($"Employee Name: {name}");
            Console.WriteLine($"Salary: {salary}");
        }
    }

    class Manager : Employee
    {
        public void Manage()
        {
            Console.WriteLine("Managing team...");
        }
    }

    class SeniorManager : Manager
    {
        public void MakeString()
        {
            Console.WriteLine($"Senior Manager: {name}");
        }
    }

    internal class MultiLevelInheritance
    {
        public void ManageTeam()
        {
            SeniorManager manager = new SeniorManager();
            manager.name = "Suhan";
            manager.salary = 50000;

            manager.DisplayEmployee();
            manager.Manage();
            manager.MakeString();
        }

        static void Main(string[] args)
        {
            MultiLevelInheritance obj = new MultiLevelInheritance();
            obj.ManageTeam();
        }
    }
}