using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    public class CustomList<T>
    {
        T[] list;
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

        public string Addthis
        {
        }
    }
}