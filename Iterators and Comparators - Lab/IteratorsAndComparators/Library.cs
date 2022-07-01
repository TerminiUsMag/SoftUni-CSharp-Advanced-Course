using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    internal class Library
    {
        private List<Book> books;

        public List<Book> Books
        {
            get
            {
                return books;
            }
            set
            {
                books = value;
            }
        }
        public Library(params Book[] booksInitial)
        {
            this.books = booksInitial.ToList();
        }

    }
}
