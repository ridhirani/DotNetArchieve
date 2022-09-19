using System;

namespace Typecating
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Implicit Type Casting******");
            float age = 9.6f;
            double myage = age;
            Console.WriteLine(myage);
            Console.WriteLine(age);

            Console.WriteLine("*****Explicit type casting********");
            double no = 87.67;
            int newNo = (int)no;
            Console.WriteLine(newNo);
            Console.WriteLine(no);
        }
    }
}
