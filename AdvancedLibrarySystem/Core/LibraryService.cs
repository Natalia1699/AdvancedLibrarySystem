using AdvancedLibrarySystem.Interfaces;
using AdvancedLibrarySystem.Models;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedLibrarySystem.Core
{
    public class LibraryService
    {
        private Repository<LibraryItem> _repository = new();

        public event Action<LibraryItem>? ItemAdded;
        public event Action<LibraryItem, User>? ItemBorrowed;

        public async Task AddItemAsync(LibraryItem item)
        {
            await Task.Delay(300);
            _repository.Add(item);
            ItemAdded?.Invoke(item);
        }

        public void BorrowItem(string title, User user)
        {
            var item = _repository
                .GetAll()
                .FirstOrDefault(i => i.Title == title);

            if (item is IBorrowable borrowable)
            {
                borrowable.Borrow(user);
                ItemBorrowed?.Invoke(item, user);
            }
        }

        public void ReturnItem(string title)
        {
            var item = _repository
                .GetAll()
                .FirstOrDefault(i => i.Title == title);

            if (item is IBorrowable borrowable)
            {
                borrowable.Return();
            }
        }

        public void ShowAllItems()
        {
            foreach (var item in _repository.GetAll())
            {
                Console.WriteLine(item);
            }
        }
        public int Count()
        {
            return _repository.GetAll().Count();
        }
    }
}