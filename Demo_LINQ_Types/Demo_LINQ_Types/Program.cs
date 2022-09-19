using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_LINQ_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 1, 2, 3, 4 };
            var result = from a in num 
                         where a < 4 
                         orderby a 
                         select a;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}
