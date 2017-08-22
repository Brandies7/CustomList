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
            for (int i = 0; i < Count; i++)
            {
                int itemCount = 0;
                if (list[i].Equals(a))
                {
                    T[] item = new T[Count - 1];
                    Count--;
                    for (int j = 0; j < i; j++)
                    {
                        itemCount++;
                        list[j] = item[j];
                    }
                    for (int j = i + 1; j < Count + 1; j++)
                    {
                        itemCount++;
                        list[j] = item[i];
                    }
                }
                return;
            }
        }

        public static CustomList <T> operator + (CustomList<T>a, CustomList<T> b)
        {
            foreach (var myItems in b)
            {
                a.Add(myItems);
            }
            return a;
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