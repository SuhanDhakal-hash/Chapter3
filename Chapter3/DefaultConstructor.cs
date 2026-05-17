using System;

namespace Chapter3
{
    class Book
    {
        public string Title;
        public string Author;


        public Book()
        {
            Title = "Math";
            Author = "Giri arut";
        }


        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public void Display()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }
    }

    class DefaultConstructor
    {
        static void Main()
        {

            Book book1 = new Book();
            book1.Display();


            Book book2 = new Book("C# Basics", "John Doe");
            book2.Display();
        }
    }
}