using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    public class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> employees)
        {
            foreach (var item in employees)
            {
                Console.WriteLine($"Rs.{item.Salary} salary creadited to {item.Name} account.");
            }
        }
    }
}
