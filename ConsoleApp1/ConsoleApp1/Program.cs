using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with date and time!");
            DateTime todaydate = new DateTime(2022,9,01,6,45,43);
            Console.WriteLine(todaydate.Year);
            Console.WriteLine(todaydate.ToString("d"));
            Console.WriteLine(todaydate.ToString("d"));
            Console.WriteLine(todaydate.ToString("D"));
            Console.WriteLine(todaydate.ToString("F"));


        }
    }
} 
