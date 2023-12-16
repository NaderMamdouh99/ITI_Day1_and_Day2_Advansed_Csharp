using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1andDat2
{
    internal class Trainee : IPayable, IComparer
    {

        decimal salary;
        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value >= 3000)
                    salary = value;
                else
                    throw new TraineeExcepation("The Salary must be Gretter than 3000");
            }

        }
        public Trainee(decimal _Salary)
        {
            Salary = _Salary;
        }

        public int Compare(object? x, object? y)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
