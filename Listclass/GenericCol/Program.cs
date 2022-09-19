using System;
using System.Collections.Generic;

namespace GenericCol
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Implementing Generic List Collections");
            //Creating a Generic List Collection  
            var webSeries = new List<string>();
            //Inserting the items 
            webSeries.Add("Vampire Diaries");
            webSeries.Add("Originals");
            webSeries.Add("The Legacies");
            webSeries.Add("Never Have I Ever");
            webSeries.Add("Europhia");
            //displaying the list
            foreach(var item in webSeries)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine(webSeries.Capacity); //8
            Console.WriteLine(webSeries.Count);//5

            //replacing items in collection
            webSeries[1] = "Twisted";
            foreach (var item in webSeries)
            {
                Console.WriteLine(item);

            }
            //removing items from collection
            webSeries.RemoveAt(2); //we can remove element by using subscript 
            webSeries.Remove("Twisted"); //we can remove element also directly passing the element itself in the remove 
            foreach (var item in webSeries)
            {
                Console.WriteLine(item);

            }
            
            
        }
    }
}
