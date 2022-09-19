using System;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Implementing Non generic hash Table Class***********");
            Hashtable myht = new Hashtable();
            myht.Add(1, "Book");
            myht.Add(2, "Pen");
            myht.Add(3, "Pencil");
            myht.Add(4, "Laptop");
            myht.Add(true, "yes");
            myht.Add(2728, "Earpones");
            myht.Add(0, "Charger");
            myht.Add(5, "Charger");

            foreach (DictionaryEntry item in myht)
            {
                Console.WriteLine($"Key:{item.Key},Value:{item.Value}");
            }
            Console.WriteLine("Removing element using remove by taking as argument");
            myht.Remove(3);
            foreach (DictionaryEntry item in myht)
            {
                Console.WriteLine($"Key:{item.Key},Value:{item.Value}");
            }
            Console.WriteLine("Count the no of items" +myht.Count);
            Console.WriteLine("Check if it contains item of key 2"+myht.Contains(2));
            Console.WriteLine("Check if key 3 is present " +myht.ContainsKey(3));
            Console.WriteLine("Check if it contains Value \"Book\""+myht.ContainsValue("Book"));
        }
    }
}
