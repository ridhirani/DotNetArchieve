using System;

namespace Exception_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4 };

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine(arr[3]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("An Exception has Occured: {0},{1})",e.Message,e.StackTrace);
                //throw;
            }
            catch  (DivideByZeroException e)
            {
                Console.WriteLine("An Exception has Occured: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Finally will Execute every time irrespective of exception");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine("{0}", arr[i]);
                }
            }
        }
    }
}
