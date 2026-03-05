using AdvancedLibrarySystem.Models;

namespace AdvancedLibrarySystem.Interfaces
{
    public interface IBorrowable
    {
        bool IsBorrowed { get; }
        void Borrow(User user);
        void Return();
    }
}