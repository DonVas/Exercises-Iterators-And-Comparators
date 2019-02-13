using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Problem1.ListyIterator
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> itemList =new List<T>();
        private int index = 0;

        public ListyIterator(List<T>itemList)
        {
            this.itemList = itemList;
            int index = 0;
        }

        public bool Move()
        {
            if (HasNext())
            {
                this.index++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if (index+1 < this.itemList.Count)
            {
                return true;
            }
            return false;
        }

        public string Print()
        {
            if (this.itemList.Count==0)
            {
                return "Invalid Operation!";
            }
            return this.itemList[index].ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.itemList.Count; i++)
            {
                yield return this.itemList[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
