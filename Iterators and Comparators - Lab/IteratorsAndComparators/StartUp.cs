using System;

namespace IteratorsAndComparators
{
     class StartUp
    {
        static void Main(string[] args)
        {
            var book = new Book("Programming Basics 2", 2010, "Nakov", "Nachev");
            var book2 = new Book("Programming Fundamentals", 2015, "Nakov", "Nachev", "Anonymous");
            var book3 = new Book("Programming Basics", 2010, "Nakov", "Nachev", "SecretAdmirer");

            var library = new Library(book, book2, book3);

            foreach (var b in library)
            {
                Console.WriteLine(b.ToString());
            }

        }
    }
}
