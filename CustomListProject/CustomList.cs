using System;

namespace CustomListProject

{
    public class CustomList<T>
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
                list = new T[(Count+1)*2];

                for (int i = 0; i < temp.Length; i++)
                {
                    list[i] = temp[i];
                }
            }

            
            }
        }

        public void Remove(CustomList<T> a)
        {
            for (int i = 0; i < a.Count; i++)
                for (int j = 0; j < a.Count; i++)
                {
                    if (i == j)
                    {
                        i--;
                    }
                }
        }
    }
}