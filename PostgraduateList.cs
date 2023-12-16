using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1andDat2
{
    internal class PostgraduateList:IEnumerable
    {
        Student[] Postgraduate;
        public Student this[int indec]
        {
            get { return Postgraduate[indec]; }
            set { Postgraduate[indec] = value; }
        }
        public PostgraduateList(int _size)
        {
            Postgraduate = new Student[_size];
        }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(Postgraduate);
        }
        class Iterator:IEnumerator
        {
            Student[] Arry;
            int Iindex;
            public Iterator(Student[] _Arry)
            {
                Arry = _Arry;

            }

            public object Current
            {
                get { return Arry[Iindex++]; }
            }

            public bool MoveNext()
            {
                return Iindex < Arry.Length;
            }

            public void Reset()
            {
                Iindex = 0;
            }
        }
    }
}
