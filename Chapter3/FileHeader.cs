using System;

namespace chapter_3
{
    interface IReader
    {
        void Read();
    }

    interface IWriter
    {
        void Write();
    }

    class FileHandler : IReader, IWriter
    {
        public void Read()
        {
            Console.WriteLine("Reading from file");
        }

        public void Write()
        {
            Console.WriteLine("Writing to file");
        }
    }

    class FileHeader
    {
        static void Main()
        {
            FileHandler fh = new FileHandler();
            fh.Read();
            fh.Write();
        }
    }
}