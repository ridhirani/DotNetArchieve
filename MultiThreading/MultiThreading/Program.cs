using System;
using System.Threading;

namespace MultiThreading
{

    public class MyThread
    {
        public static  void ThreadDisplay()
        {

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Fisrt Thread"+i);
    
            }
        }
        public static  void ThreadDisplay1()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Second Thread"+i);
            }
        }
        public static void ThreadDisplay2()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Third Thread" + i);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Multithreading in Action");
            //MyThread obj1 = new MyThread();
            //    Thread thread1 = new Thread(new ThreadStart(obj1.ThreadDisplay));
            //    thread1.Start();
            //    //creating for non static
            //    MyThread obj2 = new MyThread();
            //    Thread thread12 = new Thread(new ThreadStart(obj2.ThreadDisplay1));
            //    thread12.Start();
            Thread a = new Thread(MyThread.ThreadDisplay);
            Thread b = new Thread(MyThread.ThreadDisplay1);
            a.Start();
            b.Start();
        //    Thread c = new Thread(MyThread.ThreadDisplay2);
        //    c.Start();
            Console.WriteLine("threads");
           
        }
    }
}
