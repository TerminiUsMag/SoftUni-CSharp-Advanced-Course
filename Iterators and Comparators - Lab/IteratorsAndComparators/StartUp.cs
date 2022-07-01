using System;

namespace IteratorsAndComparators
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            var book = new Book("Programming basics", 2010, "Nakov", "Nachev");
            var book2 = new Book("Programming Fundamentals", 2015, "Nakov", "Nachev", "Anonymous");


            Console.WriteLine(book.ToString());
            Console.WriteLine(book2.ToString());

        }
    }
}
