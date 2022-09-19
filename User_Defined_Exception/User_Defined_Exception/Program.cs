using System;

namespace User_Defined_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("User Defined Exception");
            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("Temperature is Zero Exception : {0}",e.Message);
               // throw;
            }
        }
    }
}
