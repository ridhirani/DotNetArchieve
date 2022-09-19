using System;

namespace Delegate_types1
{
    public delegate void Mydelegate(int x,int y); 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Implementing Multi Casting using Anonymous delegate method");
            Mydelegate del1 = delegate (int x,int y)
            {
                //Console.WriteLine("This is a Anonomous delgate method");
                Console.WriteLine(x + y);
            };
            del1 += delegate (int x, int y)
            {
                Console.WriteLine(x - y);
            };
            del1(2,3);
        }
    }
}
