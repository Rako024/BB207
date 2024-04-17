using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rashids_List
{
    public class RashidsList<T> : IEnumerable<T>
    {
        private T[] _items;
        private int _count;
        public int Count {  get { return _count; } }

        private int _capacity;

        public int Capacity
        {
            get { return _capacity; }
        }

        //inexer
        public T this[int index] { 
            get 
            {
                if(index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException("Duz emmeli index gir! araliqda bele index yoxdu!");
                }
                return _items[index];
            }
            set
            {
                if (index < 0 || index >= _count)
                {
                    throw new IndexOutOfRangeException("Duz emmeli index gir! araliqda bele index yoxdu!");
                }
                _items[index] = value;
            }
        }

        public RashidsList()
        {
            _items = new T[0];
            _count = 0;
            _capacity = 0;
        }

        public void Add(T item)
        {
            if(_items.Length == 0)
            {
                _capacity = 4;
                Array.Resize(ref _items, _capacity);
            }
            if(_count == _items.Length)
            {
                _capacity = _items.Length * 2;
                Array.Resize(ref _items, _capacity);

            }
            _items[_count] = item;
            _count++;
        }
        public int IndexOf(T item)
        {
            return Array.IndexOf(_items, item,0,_count);
        }
        public int LastIndexOf(T item)
        {
            return Array.LastIndexOf(_items, item);
        }

        public bool Contains(T item)
        {
            return _count != 0 && IndexOf(item) != -1;
        }
        public bool Remove(T item)
        {
            int index = IndexOf(item);
            if (index >= 0)
            {
                RemoveAt(index);
                return true;
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException("Bu Index istenilen araliqda deyil!");
            }

            for (int i = index; i < _count - 1; i++)
            {
                _items[i] = _items[i + 1];
            }

            _count--;
        }

        public void CustomReverse(int index, int count)
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException("Bu Index istenilen araliqda deyil!");
            }
            Array.Reverse(_items, index, count);
        }
        public void CustomReverse()
        {

            Array.Reverse(_items, 0, _count);
        }

        public T[] ToArray()
        {
            T[] arr = new T[_count];
             Array.Copy(_items, arr, _count);
            return arr;
        }

        public void Clear()
        {
            int count = _count;
            _count = 0;
            Array.Clear(_items, 0, count);
        }

        public void Inset(T item, int index)
        {
            if (index < 0 || index > _count)
            {
                throw new IndexOutOfRangeException("Duz emmeli index gir! araliqda bele index yoxdu!");
            }
            if (index == _count)
            {
                Add(item);
            }
            else
            {
                if (_items.Length == 0)
                {
                    _capacity = 4;
                    Array.Resize(ref _items, _capacity);
                }

                if (_count == _capacity)
                {
                    _capacity = _items.Length * 2;
                    Array.Resize(ref _items, _capacity);
                }
                for(int i = _count; i > index; i--)
                {
                    _items[i] = _items[i-1];
                }
                _items[index] = item;
                _count++;

            }

        }

        public T Find(Predicate<T> predicate)
        {
            foreach(T item in _items)
            {
                if(predicate(item)) return item;
            }
            return default(T);
        }

        public RashidsList<T> FindAll(Predicate<T> predicate)
        {
            RashidsList<T> list = new RashidsList<T>();
            foreach(T item in _items)
            {
                if(predicate(item) ) list.Add(item);
            }

            return list;
        }

        public int RemoveAll(Predicate<T> predicate)
        {
            RashidsList<T> list = new RashidsList<T>();
            int count = list.Count;
            foreach(T item in list)
            {
                Remove(item);
            }
            return count;
        }

        public void Foreach(Action<T> action)
        {
            foreach(T item in _items)
            {
                action(item);
            }
        }

        public void Sort()
        {
            Array.Sort( _items,0,Count );
        }

        //forEach ucun lazimli methodlar
        public IEnumerator<T> GetEnumerator()   
        {
            for(int i = 0; i< _count; i++)
            {
                yield return _items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
