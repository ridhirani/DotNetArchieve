using Demo_User_Defined_Exception;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_User_Defined_Exception
{
    public class Outstock : Exception
    {
        public Outstock(string message) : base(message)
        {

        }
    }
    class Stock
    {
        int num = Convert.ToInt32(Console.ReadLine());
        public void Checkstock()
        {
            if (num > 5)
            {
                throw (new Outstock("Out of Stock !"));
            }
            else
            {
                Console.WriteLine("Stocks:{0}", num);

            }
        }
    }
}
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter number of products: ");
            Stock stock1 = new Stock();
            try
            {
                stock1.Checkstock();
            }
            catch (Outstock e)
            {
                Console.WriteLine("Stock Exception: {0}", e.Message);
            }

        }
    }

