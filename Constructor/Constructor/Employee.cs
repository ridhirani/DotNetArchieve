using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Employee
    {
        public string name;
        public string dept;
        public Employee()
        {
            name = "Hari";
            dept = "Mass & Com";
        }
        public Employee(string name,string dept)
        {
            this.name = "Sneh";
            this.dept = "Management";
        }
    }
    
}
