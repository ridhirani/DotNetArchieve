using System;

namespace Object_Pooling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Factory fa = new Factory();
            Employee emp = fa.GetEmployee();
            Console.WriteLine("An Object is created ");
            Employee emp2 = new Employee();
            Console.WriteLine("An second object is created");
            Employee emp3 = new Employee();
            Console.WriteLine("An third object is created");
        }
    }
}
