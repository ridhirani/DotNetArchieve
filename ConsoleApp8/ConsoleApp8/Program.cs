using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    public class SmartPhone : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string OS { get; set; }
        public bool IsFlagship { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            SmartPhone nextSmartPhone = obj as SmartPhone;
            if (nextSmartPhone != null)
            {
                return this.Price.CompareTo(nextSmartPhone.Price);
            }
            else
            {
                throw new ArgumentException("Object doesn't have a proper price");
            }
        }

        public override string ToString()
        {
            return "Name: " + Name + "||"
                    + " Price: " + Price + "||"
                    + " OS: " + OS + "||"
                    + " Is flagship Phone: " + IsFlagship;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<SmartPhone> smartPhones = new List<SmartPhone>()
            {
                new SmartPhone()
                {
                    Name = "One Plus 8",
                    IsFlagship = true,
                    OS = "Android 10",
                    Price = 55000
                },
                new SmartPhone()
                {
                    Name = "IPhone 11",
                    IsFlagship = true,
                    OS = "IOS 11",
                    Price = 75000
                },
                new SmartPhone()
                {
                    Name = "Samsung Note 10",
                    IsFlagship = true,
                    OS = "Android 10",
                    Price = 110000
                },
                new SmartPhone()
                {
                    Name = "Samsung S20 Ultra",
                    IsFlagship = true,
                    OS = "Android 10",
                    Price = 130000
                },
                new SmartPhone()
                {
                    Name = "IPhone 11 Pro",
                    IsFlagship = true,
                    OS = "IOS 11",
                    Price = 130000
                }
            };
            smartPhones.Sort();
            foreach (var item in smartPhones)
            {
                System.Console.WriteLine(item.ToString());
            }

        }
    }
}
