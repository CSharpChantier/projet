using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionSiteLib
{
    class Employee
    {
        private string name;
        private int age;
        private int salary;

        public Employee(string name, int age, int salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }

        public void Work(int hours)
        {

        }
    }
}
