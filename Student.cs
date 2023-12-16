using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1andDat2
{
    internal class Student : IComparable
    {
        public decimal Salary { get; set; }
        public int id { get; set; }
        public string Name { get; set; }
        public Student(int _id, string _Name)
        {
            id = _id;
            Name = _Name;
        }

        public override string ToString()
        {
            return $"Id = {id} :: Name = {Name}";
        }

        public int CompareTo(object? obj)
        {
            if (obj is Student)
            {
                Student s = (Student)obj;
                if (s.id == id)
                    return 0;
                else if (id > s.id)
                    return 1;
                return -1;
            }
            return -2;

        }
    }
}
