using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionSiteLib
{
    class Machine
    {
        private Employee employee;
        private int price = 0;
        private int productivity = 0;
        private bool operational = true;
        private string brand = "";
        private int weight = 0; //weight in Kg

        public Machine(int price, int productivity, string brand, int weight)
        {
            this.employee = employee;
            this.price = price;
            this.productivity = productivity;
            this.brand = brand;
            this.weight = weight;
        }

        public void Assign(List<Employee> employees)
        {
            foreach(Employee employee in employees)
            {
                //TO DO
            }
        }

        public int Repair()
        {

        }
    }
}
