using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Problem3.Stack
{
    public class CustomStack<T>:IEnumerable<T>
    {
        public CustomStack(params T[] data)
        {
            this.items = data.ToList();
        }
        private List<T> items;
        private int index;

        public void Push(params T[] itemsToAdd)
        {
            this.items.AddRange(itemsToAdd);
        }

        public T Pop()
        {
            if (this.items.Count==0)
            {
                throw new ArgumentException("No elements");
            }
           T element= this.items[this.items.Count - 1];
           this.items.RemoveAt(this.items.Count - 1);
           return element;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = items.Count - 1; i >= 0; i--)
            {
                yield return this.items[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
