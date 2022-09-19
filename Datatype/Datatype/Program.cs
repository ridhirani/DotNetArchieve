using System;

namespace Datatype
{
    class Program
    {
        static void Main(string[] args)
        {
            //integer type
            int num = 77;
            Console.WriteLine("This is a integer:" + num);
            //float type
            float num1 = 29.56F;
            Console.WriteLine("This is a float value:" + num1);
            //double type
            double num2 = 45.789D;
            Console.WriteLine("This is the double value:" + num2);
            //scientific type
            float f1 = 67.4e5F;
            Console.WriteLine("This is a Scientific number with float using e: " + f1);
            double d1 = 56.42E6D;
            Console.WriteLine("This is a Scientific number with double using E:" + d1);
            bool string1 = true;
            Console.WriteLine("This is a boolean value:" + string1);
            char c = 'B';
            Console.WriteLine("This is a Character value:" + c);
            string s = "Hey Ridhi";
            Console.WriteLine("This is a string value:" + s);

        }
    }
}
