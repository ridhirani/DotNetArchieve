using System;

namespace _1st
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.WriteLine("Hey Ridhi ! How are You?"); //writeLine will get the cursor to the next line
            //Console.Write("Hey Ridhi! how are you?"); //write will hold the cursor on the same line
            //Console.WriteLine("Hey Ridhi ! How are You?");
            //Console.ReadKey(); //we use readkey() to hold the output screen instead of this we can use the ctrl + f5 to run the code and will not face the hold screen issue

            /* Asking user to enter the input and store it in variable */
            //asking for input
            Console.WriteLine("Enter Your name:");
            //reading the input
            String name = Console.ReadLine();
            //displaying the input
            Console.WriteLine("Your name is" +name);
            //asking for integer input 
            Console.WriteLine("What is your Age:");
            //reading the integer input
            int age = Convert.ToInt32(Console.ReadLine());
            //displaying the ouutput 
            Console.WriteLine("Your Age is "+age);

        }
    }
}
