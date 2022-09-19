using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace Test
{
    class Program
    {
        static void combinationUtil(int[] arr, int[] data,
                               int start, int end,
                               int index, int r)
        {
           
            if (index == r)
            {
                for (int j = 0; j < r; j++)
                    Console.Write(data[j] + " ");
                Console.WriteLine("");
                return;
            }

            
            for (int i = start; i <= end &&
                      end - i + 1 >= r - index; i++)
            {
                data[index] = arr[i];
                combinationUtil(arr, data, i + 1,
                                end, index + 1, r);
            }
        }

       
        static void printCombination(int[] arr,int n, int r)
        {
            
            int[] data = new int[r];

            
            combinationUtil(arr, data, 0,
                            n - 1, 0, r);
        }
       
        static void Main(string[] args)
        {

             int[] arr = { 1, 2, 3, 4, 5 };
             int r = 3;
             int n = arr.Length;
             printCombination(arr, n, r);
            //int sum = 0;
            //foreach (var item in arr)
            //{
            //    sum += item;
            //}
            //Console.WriteLine(sum);
            //Write a program in C# SharpCo 

            //Test Data : 


            //int[] arr3 = { 1, 5 ,1 };
            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    bool isDuplicate = false;
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (arr3[i] == arr3[j])
            //        {
            //            isDuplicate = true;
            //            break;
            //        }
            //        if (!isDuplicate)
            //        {
            //            Console.WriteLine(arr3[i]);

            //        }

            //    }

            //}
            //Console.ReadLine();

            //foreach (var i in arr3.GroupBy(i => i).Where(g => g.Count() == 1).Select(g => g.Key)) ;
            //Console.WriteLine("Uniqu Element of array is:" + i);


            //int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write(array[i, j] + " ");

            //    }
            //    Console.WriteLine();

            //}


            //Console.WriteLine("Enter the username");
            //Console.ReadLine();
            //Console.WriteLine("Enter the password");
            //Console.ReadLine();
            //Console.WriteLine("Entered Successfully");


            //string Roman(int num)
            //{

            //    string result = "";

            //    Dictionary<string, int> romanNumbersDictionary = new()
            //    {
            //        {
            //            "I",
            //            1
            //        },
            //        {
            //            "IV",
            //            4
            //        },
            //        {
            //            "V",
            //            5
            //        },
            //        {
            //            "IX",
            //            9
            //        },
            //        {
            //            "X",
            //            10
            //        },
            //        {
            //            "XL",
            //            40
            //        },
            //        {
            //            "L",
            //            50
            //        },
            //        {
            //            "XC",
            //            90
            //        },
            //        {
            //            "C",
            //            100
            //        },
            //        {
            //            "CD",
            //            400
            //        },
            //        {
            //            "D",
            //            500
            //        },
            //        {
            //            "CM",
            //            900
            //        },
            //        {
            //            "M",
            //            1000
            //        }
            //    };
            //    foreach (var item in romanNumbersDictionary.Reverse())
            //    {
            //        if (num <= 0) break;
            //        while (num >= item.Value)
            //        {
            //            result += item.Key;
            //            num -= item.Value;
            //        }
            //    }
            //    return result;
            //}
            //Console.WriteLine(Roman(49));

            String[] cultureNames = { "en-AU", "sv-SE" };
            String[] strs1 = { "case",  "encyclopedia",
                            "encyclopedia", "Archeology" };
            String[] strs2 = { "Case", "encyclopedia",
                            "encyclopedia" , "ARCHEOLOGY" };
            StringComparison[] comparisons = (StringComparison[])Enum.GetValues(typeof(StringComparison));

            foreach (var cultureName in cultureNames)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureName);
                Console.WriteLine("Current Culture: {0}", CultureInfo.CurrentCulture.Name);
                for (int ctr = 0; ctr <= strs1.GetUpperBound(0); ctr++)
                {
                    foreach (var comparison in comparisons)
                        Console.WriteLine("   {0} = {1} ({2}): {3}", strs1[ctr],
                                          strs2[ctr], comparison,
                                          String.Equals(strs1[ctr], strs2[ctr], comparison));

                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }

   
}
