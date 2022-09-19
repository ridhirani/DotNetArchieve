using System;
using System.Threading;

namespace Check_Alive
{
    public  class One
    {
        public  void Disp1()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"My Worker Thread:{i}");
                Thread.Sleep(1000);
            }
        }
    }
    public class Two
    {
        public static void Disp2()
        {
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine($"My Worker Thread2:{i}");
                Thread.Sleep(200);
            }
        }
    }
    class Program
    {
        [Obsolete]
       
        static void Main(string[] args)
        {
            One o1 = new One(); 
            Thread th = new Thread(new ThreadStart(o1.Disp1));
           // Thread th1 = new Thread(Two.Disp2);
            Console.WriteLine("Is First Thread is Alive or Not? {0}", th.IsAlive);
            //Console.WriteLine("Is Second Thread is Alive or Not? {0}", th1.IsAlive);
            Console.WriteLine("after using Start()");
            th.Start();
           // th1.Start();
            Console.WriteLine("Is First Thread is Alive or Not? {0}", th.IsAlive);
           // Console.WriteLine("Is Second Thread is Alive or Not? {0}", th1.IsAlive);
            Console.WriteLine("after calling suspend method");
            th.Suspend();
            Console.WriteLine("status:{0}" , th.ThreadState);
            th.Resume();
            Console.WriteLine("after calling Res method");

            Console.WriteLine("status:{0}" , th.ThreadState);


        }
    }

}
//Suspend() Resume()  stages of thread.

