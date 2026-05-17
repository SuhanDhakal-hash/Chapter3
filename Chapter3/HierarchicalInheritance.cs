using System;

namespace chapter_3
{
    class Account
    {
        public int accountNumber;
        public double amount;

        public void Display()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
        }
    }

    class SavingsAccount : Account
    {
        public void DisplaySavings()
        {
            Console.WriteLine("Savings Account");
            Console.WriteLine($"Amount: {amount}");
        }
    }

    class CurrentAccount : Account
    {
        public void DisplayCurrent()
        {
            Console.WriteLine("Current Account");
            Console.WriteLine($"Amount: {amount}");
        }
    }

    class HierarchicalInheritance
    {
        static void Main(string[] args)
        {
            SavingsAccount sa = new SavingsAccount();
            sa.accountNumber = 101;
            sa.amount = 5000;

            sa.Display();
            sa.DisplaySavings();

            Console.WriteLine();

            CurrentAccount ca = new CurrentAccount();
            ca.accountNumber = 202;
            ca.amount = 8000;

            ca.Display();
            ca.DisplayCurrent();
        }
    }
}