using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1andDat2
{
    internal class TwoItemOperation<T>
    {

        public T Num1 { get; set; }
        public T Num2 { get; set; }

        public TwoItemOperation(T _N1, T _N2)
        {
            Num1 = _N1;
            Num2 = _N2;
        }
        public double Sum(T Num1, T Num2)
        {
            dynamic Number1 = Num1;
            dynamic Number2 = Num2;
            return Number1 + Number2;
        }
        public double Sub(T Num1, T Num2)
        {
            var Number = Convert.ToDouble(Num1);
            var Number2 = Convert.ToDouble(Num2);
            return Number - Number2;
        }

        public double Div(T Num1, T Num2)
        {
            dynamic Div1 = Num1;
            dynamic Div2 = Num2;
            return Div1 / Div2;
        }
    }
}
