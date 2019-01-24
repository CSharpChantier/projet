using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionSiteLib
{
    class ConstructionSite
    {
        private string name;
        private List<Machine> machines = new List<Machine>();
        private List<Employee> employees = new List<Employee>();
        private int capital;


        public ConstructionSite(string name, int capital)
        {
            this.name = name;
            this.capital = capital; 
        }

        public void BuyMachine(Machine machine)
        {

        }

        public void HireEmployee(Employee employee)
        {

        }
    }
}
