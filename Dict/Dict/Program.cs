using System;
using System.Collections;
using System.Collections.Generic;

namespace Dict
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementation of Dictionry Generic class");
            Dictionary<string,string> mydict = new Dictionary<string,string>();
            mydict.Add("user1","Ridhi");
            mydict.Add("user2", "Rani");
            mydict.Add("user3", "Shreh");
            foreach(KeyValuePair<string,string> item in mydict)
            {
                Console.WriteLine($"key {item.Key},Valu:{item.Value}");
            }
            Console.WriteLine("Removing key:user 1");
            Console.WriteLine(mydict.Remove("user1"));
            foreach (KeyValuePair<string, string> item in mydict)
            {
                Console.WriteLine($"key {item.Key},Valu:{item.Value}");
            }
            Console.WriteLine(mydict.ContainsKey("user1"));

            Console.WriteLine(mydict.ContainsValue("Shreh"));
            mydict["user2"] = "Sunny";
            
            foreach (KeyValuePair<string, string> item in mydict)
            {
                Console.WriteLine($"key {item.Key},Valu:{item.Value}");
            }


        }
    }
}
