using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1andDat2
{
    internal class Employee : IPayable
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
    }
}
