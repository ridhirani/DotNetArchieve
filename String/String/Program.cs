using System;
using System.Text;

namespace String
{
    class Program : Student
    {
        static void Main(string[] args)
        {
            //__________________________________________String ________________________________________________________________________________

            /*Console.WriteLine("Implementation of string");
            string s1 = "TEST";
            char[] s2 = { 'T', 'E', 'S', 'T' };
            if (s1 == s2.ToString()) 
            {
                Console.WriteLine("They are same");
            }
            else
            {
                Console.WriteLine("They are different");
            }
            Console.WriteLine(s1.CompareTo(s2.ToString()));
            Console.WriteLine(s1.Equals(s2.ToString()));
            Console.WriteLine(s1.Replace('S', 'X'));
            Console.WriteLine(s1.Substring(0, 2));
            Console.WriteLine(s1.GetHashCode());

            //____________________________________________________________string Builder class______________________________________________________________________________

            StringBuilder mysb = new StringBuilder("Hello World", 40);
            Console.WriteLine(mysb);
            mysb.AppendLine("How you Doing!");
            Console.Write(mysb);
            mysb.AppendLine("How you Doing!");
            Console.Write(mysb);

            StringBuilder totalAmount = new StringBuilder("The total amount is:");
            totalAmount.AppendFormat("{0:C}", 240);
            Console.WriteLine(totalAmount); */

            //_________________________________________________________________________Jagged Array__________________________________________________________________________________

            /*
            Console.WriteLine("Jagged Array Implementation");
            int[][] jarr = new int[3][];
            jarr[0] = new int[4] { 1,2,3,4};
            jarr[1] = new int[6] {2,3,4,5,6,7 };
            jarr[2] = new int[] { 2, 3, 4, 5, 7, 8, 9, 9 };
            //using foreach loop
            foreach (var item in jarr)
            {
                //Console.Write(item);
                foreach (var item1 in item)
                {
                    Console.Write(item1 +" ");
                    //Console.WriteLine();
                }
                Console.WriteLine();

            }
            //using for loop
            for (int i = 0; i < jarr.Length; i++)
            {
                for (int j = 0; j < jarr[i].Length ; j++)
                {
                    Console.Write(jarr[i][j] + " ");

                }
                Console.WriteLine();
            }
            */

            //____________________________________________________Params Keyword___________________________________________________________________________

            /*Console.WriteLine("PARAM KEYWORD");
             //Program mydata = new Program();
             //mydata.Show("Ridhi","ridhi@gmail.com","Bihar",21);
             //Program mydada1 = new Program();
             //mydada1.Show(2, 3);
             // Greeting("Ridhi");
             //Greeting("Shreh");
             //Greeting();
             Emp("Abc", "Ahgjh", 8622);
             Emp("c", "Afgfjh", 22);
             Emp("bc", "jh", 52);




             // public void Show(params Object[] emp)
             //{
             // for (int i = 0; i < emp.Length; i++)
             //{
             //  Console.Write(emp[i] +" ,");
             //}


             //static void Greeting(string Fname ="Nait")
             // {
             //     Console.WriteLine(Fname + " is software  trainee");
             // }

             /*Conclusions:
              * 1)When we use static keyword we dont need to create objects to access the function we can just write the Function name and under the parenthesis we can pass the arguments
              * 2)String Builder class thatcan be used to implement the mutable strings like we can add the string after the definition of string builder .We can add strings in the existed string
              * 3)PARAMS keyword - we can write this keyword in the paramenter of methods and by using that we can pass number of variable no of argumements */

            /*
                        //Named Parameters 
                        static void Emp(string Ceo ,string companyName,int turnover)
                        {
                            Console.WriteLine($"CEO:{Ceo},Company Name:{companyName},Turn Over:{turnover}");

                        }*/

            //________________________________________Funnction Overloading____________________________________________________

            /*  Console.WriteLine(Add(2, 345));
              Console.WriteLine(Add(56.34F, 672.67F));
              Console.WriteLine(Add(56.34F, 672));
              Console.WriteLine(Add(56, 672.67F));

              Console.WriteLine(Add("hi", "good morning"));

          }
          static int Add(int x, int y)
          {
              return x + y;
          }
          static float Add(float x, float y)
          {
              return x + y;
          }
          static string Add(string x, string y)
          {
              return x + y;
          }
          static float Add(int x, float y)
          {
              return x + y;
          }
          static float Add(float x, int y)
          {
              return x + y;
          }*/

            Student s1 = new Student();
            Program p1 = new Program();
            p1.StudentMessage(); //we are calling the function of Student class using the Program class object
            s1.StudentMessage(); // we are calling the function of Student class using student class object
        }
    }
}