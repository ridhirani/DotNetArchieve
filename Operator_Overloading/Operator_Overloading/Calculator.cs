using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Calculator
    {
        public int number1, number2,result;
        public Calculator(int num1,int num2)
        {
            number1 = num1;
            number2 = num2;
        }
        public static Calculator operator  + (Calculator c1 ,Calculator c2)
        {
            Calculator r = new Calculator(0,0);
            r.number1 = c1.number1 + c2.number1;
            r.number2 = c1.number2 + c2.number2;

            return r;

        }
        public void Print()
        {
            Console.WriteLine("Number1_sum:" + number1);
            Console.WriteLine("Number2_sum:" + number2);


        }
    }
}
