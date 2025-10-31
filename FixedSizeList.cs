using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_adv2
{
    internal class FixedSizeList<T>
    {

        #region 3
        //private T[] items;
        //private int count;
        //private int capacity;

        //public FixedSizeList(int capacity)
        //{
        //    if (capacity <= 0)
        //        throw new ArgumentException("Capacity must be greater than zero.");

        //    this.capacity = capacity;
        //    items = new T[capacity];
        //    count = 0;
        //}

        //public void Add(T item)
        //{
        //    if (count >= capacity)
        //        throw new InvalidOperationException($"Cannot add more elements. The list is full (capacity: {capacity}).");

        //    items[count] = item;
        //    count++;
        //}

        //public T Get(int index)
        //{
        //    if (index < 0 || index >= count)
        //        throw new IndexOutOfRangeException($"Invalid index: {index}. Valid range is 0 to {count - 1}.");

        //    return items[index];
        //}

        //public int Count => count;
        //public int Capacity => capacity; 
        #endregion
    }
}
