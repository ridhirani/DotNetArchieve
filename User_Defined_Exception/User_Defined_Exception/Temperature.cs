using System;
using System.Collections.Generic;
using System.Text;

namespace User_Defined_Exception
{   public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message) :base(message)
        {

        }
    }
    class Temperature
    {
        int temperature = 0;
        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temperature Found"));
            }
            else
            {
                Console.WriteLine("temperature: {0}", temperature);
            }
        }
    }
}
