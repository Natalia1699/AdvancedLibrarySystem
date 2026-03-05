using System;
using AdvancedLibrarySystem.Models;

namespace AdvancedLibrarySystem.Models
{
    public abstract class LibraryItem
    {
        public string Title { get; protected set; }
        public string Author { get; protected set; }
        public int Year { get; protected set; }

        public User? BorrowedBy { get; protected set; }

        public static int ItemCount { get; private set; }

        protected LibraryItem(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
            ItemCount++;
        }

        public abstract string GetDescription();

        public override string ToString()
        {
            return $"{Title} - {Author} ({Year})";
        }
    }
}
