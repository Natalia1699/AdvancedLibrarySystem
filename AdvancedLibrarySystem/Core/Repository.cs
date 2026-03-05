using System.Collections.Generic;

namespace AdvancedLibrarySystem.Core
{
    public class Repository<T>
    {
        private List<T> _items = new List<T>();

        public void Add(T item)
        {
            _items.Add(item);
        }

        public T this[int index]  
        {
            get { return _items[index]; }
        }

        public IEnumerable<T> GetAll()
        {
            return _items;
        }
    }
}