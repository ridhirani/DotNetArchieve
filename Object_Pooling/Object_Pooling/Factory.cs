using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Object_Pooling
{
    class Factory
    {
        private static int poolMaxSize = 2;
        private static readonly Queue ObjPool = new Queue(poolMaxSize);
        public Employee GetEmployee()
        {
            Employee OEmployee = new Employee();
            if (Employee.Counter <= poolMaxSize && ObjPool.Count > 0)
            { 
                OEmployee = RetriveFromPool();
            }
            else
            {
                OEmployee = GetNewEmployee();
            }
            return OEmployee;
        }
        protected Employee RetriveFromPool()
        {
            Employee OEmp;
            if (ObjPool.Count>0)
            {
                OEmp = (Employee)ObjPool.Dequeue();  //boxing the datatyoe
                Employee.Counter--;
            }
            else
            {
                OEmp = new Employee();
            }
            return (OEmp);
        }
        private Employee GetNewEmployee()
        {
            Console.WriteLine("New object is created"); 
            Employee OEmp = new Employee();
            ObjPool.Enqueue(OEmp);
            return OEmp;
        }


    }
    class Employee
    { 
        public static int Counter = 0;
        public Employee()
        {
            ++Counter;

        }
        private string _FirstName;
        public string Firstname
        {
            get
            {
                return _FirstName;
            }
            set 
            {
                _FirstName = value;
            } 
        }
    }
}
