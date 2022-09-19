using System;
using System.Collections;
using System.Collections.Generic;

namespace collection
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("*****************Stack <T> Class***************");
             //represnts a variable size last -in-first -out(LIFO)
              // Creating a stack collection
             Stack<string> numbers = new Stack<string>();
             //Inserting elements in stack
             numbers.Push("One");
             numbers.Push("Two");
             numbers.Push("Three");
             numbers.Push("Four");
             numbers.Push("Five");
             numbers.Push("Six");

             //displaying elemets of stack
             foreach (var item in numbers)
             {
                 Console.Write(item + ",");
             }
             Console.WriteLine("**********Removing elements from stack************");
             //deletion elements from stack
             numbers.Pop();  // it will pop out the last element of stack as it follows LIFO
             foreach (var item in numbers)
             {
                 Console.Write(item + ",");
             }

             //creating a copy of the stack using ToArray() method
             Console.WriteLine("*******Copying the content of stack in another stack************");
             Stack<string> numbersCopy = new Stack<string>(numbers.ToArray());
             foreach (string item in numbers)
             {
                 Console.Write(item + ",");
             }

             numbers.Clear();  // it will delete all the elements of stack
             foreach (string item in numbers)
             {
                 Console.Write(item + ",");
             }


             //peek() method will return the Top element placed in the stack
            Console.WriteLine(numbers.Peek());

             //contains will return the boolean value it checks if the item is presnt i the stack
             Console.WriteLine(numbers.Contains("One")); */

           /* Console.WriteLine("*************Stack No Generic class********");
            Stack lang = new Stack();
            lang.Push("C#");
            lang.Push("C");
            lang.Push("C++");
            lang.Push("Java");
            lang.Push("HTML");
            lang.Push("Python");
            Console.WriteLine("Original Stack");
            foreach (var item in lang)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Stack before the deletion");
            foreach (var item in lang)
            {
                Console.WriteLine(item);
            }
            lang.Pop();
            Console.WriteLine("Stack after the deletion");
            foreach (var item in lang)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(lang.Peek());
            Console.WriteLine(lang.Contains("Java"));
            Console.WriteLine("Stack after using clear()");
            lang.Clear();
            foreach (var item in lang)
            {
                Console.WriteLine(item);  //nothing would print
            }
            
            */
        }
    }
}
