using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDesignPattern
{
    public class Student
    {
        public string Name { get; set; }
        public string Class { get; set; }
        public Address StudentAddress { get; set; }

        public Student GetClone()
        {
            return (Student)this.MemberwiseClone();
        }

        public Student GetDeepClone()
        {
            Student student = (Student)this.MemberwiseClone();
            student.StudentAddress = StudentAddress.GetClone();
            return student;
        }
    }

    public class Address
    {
        public string StudentAddress { get; set; }

        public Address GetClone()
        {
            return (Address)this.MemberwiseClone();
        }
    }
}
