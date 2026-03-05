using Xunit;
using AdvancedLibrarySystem.Models;
using AdvancedLibrarySystem.Core;
using System.Threading.Tasks;

namespace AdvancedLibrarySystem.Tests
{
    public class LibraryTests
    {
        [Fact]
        public async Task AddItem_ShouldIncreaseRepositoryCount()
        {
            var library = new LibraryService();
            var book = new Book("Test", "Author", 2024);

            await library.AddItemAsync(book);

            Assert.Equal(1, library.Count());
        }

        [Fact]
        public async Task BorrowItem_ShouldAssignUser()
        {
            var library = new LibraryService();
            var book = new Book("TestBook", "Author", 2024);
            var user = new User("Anna");

            await library.AddItemAsync(book);
            library.BorrowItem("TestBook", user);

            Assert.True(book.IsBorrowed);
            Assert.Equal(user, book.BorrowedBy);
        }

        [Fact]
        public async Task BorrowItem_Twice_ShouldThrowException()
        {
            var library = new LibraryService();
            var book = new Book("TestBook2", "Author", 2024);
            var user = new User("Anna");

            await library.AddItemAsync(book);
            library.BorrowItem("TestBook2", user);

            Assert.Throws<System.InvalidOperationException>(() =>
                library.BorrowItem("TestBook2", user));
        }

        [Fact]
        public void OperatorPlus_ShouldCombineTitles()
        {
            var book1 = new Book("A", "Author", 2022);
            var book2 = new Book("B", "Author", 2022);

            var combined = book1 + book2;

            Assert.Equal("A & B", combined.Title);
        }

        [Fact]
        public async Task AddItem_ShouldTriggerEvent()
        {
            var library = new LibraryService();
            var book = new Book("EventTest", "Author", 2024);

            bool eventTriggered = false;

            library.ItemAdded += (item) =>
            {
                eventTriggered = true;
            };

            await library.AddItemAsync(book);

            Assert.True(eventTriggered);
        }
    }
}