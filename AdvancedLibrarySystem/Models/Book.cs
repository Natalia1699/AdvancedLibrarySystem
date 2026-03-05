using AdvancedLibrarySystem.Interfaces;

namespace AdvancedLibrarySystem.Models
{
    public class Book : LibraryItem, IBorrowable
    {
        public bool IsBorrowed => BorrowedBy != null;

        public Book(string title, string author, int year)
            : base(title, author, year)
        {
        }

        public override string GetDescription()
        {
            return $"Book: {Title}";
        }

        public void Borrow(User user)
        {
            if (IsBorrowed)
                throw new InvalidOperationException("Book already borrowed.");

            BorrowedBy = user;
        }

        public void Return()
        {
            BorrowedBy = null;
        }

        public static Book operator +(Book b1, Book b2)
        {
            return new Book(
                $"{b1.Title} & {b2.Title}",
                b1.Author,
                b1.Year
            );
        }
    }
}