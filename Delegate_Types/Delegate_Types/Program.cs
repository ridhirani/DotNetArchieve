using System;

namespace Delegate_Types
{
    public delegate void Delmethod(int x, int y, int z);
    class Program
    {   
        public void Ag(int x,int y,int z)
        {
            Console.WriteLine(x + y - z);
        }
        public void Total(int x,int y,int z)
        {
            Console.WriteLine(x + y + z);
        } 
        static void Main(string[] args)
        {
            Console.WriteLine("Multi Casting Delegates");
            Program o1 = new Program();
            Delmethod del = new Delmethod(o1.Ag);
            del += new Delmethod(o1.Total);
            del(3, 3, 3);
            Console.WriteLine("After Removing the Ag() Reference ");
            del -= new Delmethod(o1.Total);
            del(2, 3, 5);
            

        }
    }
}
