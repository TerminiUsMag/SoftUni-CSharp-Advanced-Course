using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IteratorsAndComparators
{
    internal class Book
    {
        public List<string> Authors { get; private set; }
        public int Year { get; private set; }
        public string Title { get; private set; }
        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors.ToList();
        }
        public override string ToString()
        {
            return $"Book Title: {this.Title}, Book Year: {this.Year}, Book Authors: {string.Join(", ", this.Authors)}";
        }
    }
}
