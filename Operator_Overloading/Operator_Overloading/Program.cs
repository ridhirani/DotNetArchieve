using System;

namespace Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator n1 = new Calculator(20,2);
            Calculator n2 = new Calculator(4,3);
            Calculator n3 = new Calculator(0,0);
            n3 = n1 + n2;
            n3.Print();
        }
    }
}
