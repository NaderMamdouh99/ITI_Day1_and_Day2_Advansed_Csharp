using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1andDat2
{
    internal class GList<T>
    {
        int Gindex;
        T[] arr;


        public GList(int _Size)
        {
            Gindex = 0;
            arr = new T[_Size];

        }
        public void Add(T item)
        {
            arr[Gindex++] = item;
        }

        public void Insert(int index, T item)
        {
            if (index < arr.Length)
            {
                arr[index] = item;
            }
        }
    }
}
