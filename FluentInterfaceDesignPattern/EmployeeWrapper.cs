using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterfaceDesignPattern
{
    public class EmployeeWrapper
    {
        Employee employee = new Employee();
        
        public EmployeeWrapper NameOfTheEmployee(string fullName)
        {
            employee.FullName = fullName;
            return this;
        }

        public EmployeeWrapper Born(string birthdate)
        {
            employee.DateOfBirth = Convert.ToDateTime(birthdate);
            return this;
        }

        public EmployeeWrapper WorkingOn(string department)
        {
            employee.Department = department;
            return this;
        }

        public EmployeeWrapper StaysAt(string address)
        {
            employee.Address = address;
            return this;
        }

        public Employee GetEmployeeDetails()
        {
            return employee;
        }
    }
}
