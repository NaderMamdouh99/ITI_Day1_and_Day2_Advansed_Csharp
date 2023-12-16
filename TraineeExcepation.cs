using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1andDat2
{
    internal class TraineeExcepation : Exception
    {
        public TraineeExcepation(string message) : base(message)
        {

        }
    }
}
