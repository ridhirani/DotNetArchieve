using System;
using System.Collections.Generic;

namespace IComparer_IComparable
{    public class Laptop : IComparable
    {
        public string Ram { get; set; }
        public string Rom { get; set; }
        public string Resolution { get; set; }

        public int CompareTo(object obj)
        {
            Laptop lap = (Laptop)obj;
            return String.Compare(this.Ram,lap.Ram);
        }

        public override string ToString()
        {
            return "RAM: " + Ram + " || "
                    + " ROM: " + Rom + "||"
                    + " RESOLUTION: " + Resolution;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of IComperable");
            List<Laptop> list = new List<Laptop>();
            {
                new Laptop()
                {
                    Ram = "16 GB",
                    Rom = "552 GB",
                    Resolution = "1080"

                };
                new Laptop()
                {
                    Ram = "8 GB",
                    Rom = "256 GB",
                    Resolution = "720"

                };
                new Laptop()
                {
                    Ram = "16 GB",
                    Rom = "256 GB",
                    Resolution = "720"

                };
                new Laptop()
                {
                    Ram = "8 GB",
                    Rom = "552 GB",
                    Resolution = "720"

                };
                
                
            };


        }
    }
}
