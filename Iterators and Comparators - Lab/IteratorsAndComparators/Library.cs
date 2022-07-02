using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
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
        //Short IEnumerator Implementation: 
        public IEnumerator<Book> GetEnumerator()
        {
            this.books.Sort();
            for (int i = 0; i < books.Count; i++)
            {
                yield return books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //Long IEnumerator Implementation:

        //class LibraryIterator : IEnumerator<Book>
        //{
        //    private List<Book> books;
        //    private int currentIndex;
        //    public LibraryIterator(IEnumerable<Book> books)
        //    {
        //        this.Reset();
        //        this.books = books.ToList();
        //    }

        //    public Book Current => this.books[currentIndex];

        //    object IEnumerator.Current => this.Current;

        //    public void Dispose()
        //    {
        //    }

        //    public bool MoveNext()
        //    {
        //        this.currentIndex++;
        //        return currentIndex < books.Count;
        //    }

        //    public void Reset()
        //    {
        //        this.currentIndex = -1;
        //    }
        //}

        //public IEnumerator<Book> GetEnumerator()
        //{
        //    return new LibraryIterator(books);
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return GetEnumerator();
        //}
    }
}
