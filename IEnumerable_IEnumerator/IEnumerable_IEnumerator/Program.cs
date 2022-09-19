using System;
using System.Collections.Generic;

namespace IEnumerable_IEnumerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with IEnumerable Interface");
            List<String> Month = new List<string>();
            Month.Add("Jan");
            Month.Add("Feb");
            Month.Add("Mar");
            Month.Add("Aug");
            //Creating IEnumerable String
            IEnumerable<string> IEnumerableOfString =(IEnumerable<string>)Month;
            //using IEnumerable object
            foreach (string months in IEnumerableOfString)
            {
                Console.WriteLine(months);
            }
            Console.WriteLine("Working with IEnumerator Interface");
            IEnumerator<string> IEnumeratorOfString = Month.GetEnumerator();
            while (IEnumeratorOfString.MoveNext())
            {
                Console.WriteLine(IEnumeratorOfString.Current);
            }

                }
    }
}
