using System;

namespace chapter_3
{
    class Movie
    {
        public string name;


        public Movie(string name)
        {
            this.name = name;
        }


        public void PrintMovie()
        {
            Console.WriteLine($"Movie name: {this.name}");
        }
    }

    class ParameterConstructor
    {
        static void Main()
        {

            Movie movieObj = new Movie("Inception");


            movieObj.PrintMovie();
        }
    }
}