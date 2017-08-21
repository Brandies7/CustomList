using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomListProject

{
    public class CustomList<T> : IEnumerable<T>
    {
        private T[] list;
        public int Count;

        public CustomList()
        {
            list = new T[Count];
        }

        public T this[int i]
        {
            get { return list[i]; }
            set { list[i] = value; }
        }

        public void Add(T a)
        {
            if (list.Length <= Count)
            {
                T[] temp = list;
                list = new T[(Count + 1) * 2];

                for (int i = 0; i < temp.Length; i++)
                {
                    list[i] = temp[i];

                    list[Count] = a;
                    Count++;
                }
            }
        }

        public void Remove(T a)
        {
            if (list.Length <= Count)
                for (int i = 0; i < list.Length; i++)
                    for (int j = 0; j < list.Length; i--)
                    {
                        {
                        }
                    }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}