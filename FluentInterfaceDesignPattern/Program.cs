using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentInterfaceDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeWrapper emp = new EmployeeWrapper();

            emp
                .NameOfTheEmployee("Akash Uttam Divekar")
                .Born("25/7/1997")
                .WorkingOn("IT")
                .StaysAt("Mumbai");

            var result = emp.GetEmployeeDetails();

            Console.WriteLine($"Full Name : {result.FullName}\nDate Of Birth : {result.DateOfBirth}\nDepartment : {result.Department}\nAddress : {result.Address}");

            Console.Read();
        }
    }
}
