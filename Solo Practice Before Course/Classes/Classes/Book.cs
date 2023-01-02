using System;

namespace Classes
{
    public class Book
    {
        public string Name { get; }
        public string Author { get; }
        public int Year { get; }

        public Book(string name, string author, int year)
        {
            Name = name;
            Author = author;
            Year = year;
        }
    }
}
