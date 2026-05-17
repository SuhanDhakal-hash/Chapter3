using System;

namespace chapter_3
{
    class DestructorExample
    {

        public DestructorExample()
        {
            Console.WriteLine("Constructor called");
        }

        ~DestructorExample()
        {
            Console.WriteLine("Destructor called");
        }
    }

    class Dest
    {
        static void Main()
        {
            DestructorExample obj = new DestructorExample();

            Console.WriteLine("Doing something...");


            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}