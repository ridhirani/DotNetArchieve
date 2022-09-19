using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Employee emp1 = new Employee();
            //Console.WriteLine(emp1.name);
            //Console.WriteLine(emp1.dept);
            emp1.dept = "Testing";//Changing the default value initialized by constructor
            //Console.WriteLine(emp1.name);
            //Console.WriteLine(emp1.dept);
            //Employee emp3 = new Employee();
            Employee emp2 = new Employee("Neha","Digital Marketing");
            Console.WriteLine(emp2.name, emp2.dept);
            //Console.WriteLine(emp3.name, emp3.dept);

        }
    }
}
