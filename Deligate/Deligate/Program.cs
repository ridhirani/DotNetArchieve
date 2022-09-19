using System;

namespace Deligate
{
    public delegate void Delmethod(int x, int y);
    class Program
    {

        public void Add(int x, int y)
        {
            Console.WriteLine("addition");
            Console.WriteLine(x + y);
        }
        public void Subtract(int x, int y)
        {
            Console.WriteLine("subtraction");
            Console.WriteLine(x - y);
        }
        static void Main(string[] args) 
        {
            Console.WriteLine("MultiCasting Delegate");
            Program obj1 = new Program();
            Delmethod del = new Delmethod(obj1.Add);
            //multicasting delegate is like this
            del += new Delmethod(obj1.Subtract);
            del(4, 6);
            Console.WriteLine(" After removing the ref of Add()");
            del -= new Delmethod(obj1.Add);
            del(7, 4);
        }
    }
}
        