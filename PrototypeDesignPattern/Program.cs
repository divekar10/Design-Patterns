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
            #region shallow copy1
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
            #endregion shallow copy1

            #region shallow copy2
            Student student1 = new Student();
            student1.Name = "Akash";
            student1.Class = "TYIT";
            student1.StudentAddress = new Address() { StudentAddress = "Mumbai" };
            Console.WriteLine($"Name : {student1.Name}\nClass : {student1.Class}\nAddress : {student1.StudentAddress.StudentAddress}");

            Student student2 = student1.GetClone();
            student2.Name = "Vaibhav";
            student2.Class = "FYIT";
            student2.StudentAddress.StudentAddress = "Andheri";
            Console.WriteLine($"Name : {student2.Name}\nClass : {student2.Class}\nAddress : {student2.StudentAddress.StudentAddress}");

            #endregion shallow copy2

            #region deep copy

            Student stud1 = new Student();
            stud1.Name = "Akash";
            stud1.Class = "TYIT";
            stud1.StudentAddress = new Address() { StudentAddress = "Thane" };

            Console.WriteLine($"Name : {stud1.Name}\nclass : {stud1.Class}\nAddress : {stud1.StudentAddress.StudentAddress}\n");

            Student stud2 = stud1.GetDeepClone();
            stud2.Name = "Prasad";
            stud2.Class = "TYIT";
            stud2.StudentAddress = new Address() { StudentAddress = "Dadar" };

            Console.WriteLine($"Name : {stud2.Name}\nclass : {stud2.Class}\nAddress : {stud2.StudentAddress.StudentAddress}");

            #endregion deep copy

            Console.ReadLine();
        }
    }
}
