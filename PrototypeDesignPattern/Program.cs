using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //object 1
            Employee emp1 = new Employee();
            emp1.Name = "Akash";
            emp1.Department = "IT";

            Console.WriteLine($"Name : {emp1.Name}\nDepartment : {emp1.Department}\n\n");

            //cloned object 1
            Employee emp2 = emp1.GetClone();

            emp2.Name = "Vaibhav";
            emp2.Department = "HR";
            Console.WriteLine($"Name : {emp2.Name}\nDepartment : {emp2.Department}\n");

            Console.WriteLine("Cloned\n");
            Employee emp3 = emp2.GetClone();
            Console.WriteLine($"Name : {emp3.Name}\nDepartment : {emp3.Department}");

            Console.ReadLine();
        }
    }
}
