using AdapterDesignPattern.Adaptee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region program1
            //string[,] employeesArray = new string[5, 4]
            //{
            //    {"101","Akash","SE","70000" },
            //    {"102","Sanket","SE","60000" },
            //    {"103","Ajay","SE","80000" },
            //    {"104","Vaibhav","SE","50000" },
            //    {"105","Pranay","SE","60000" }
            //};

            //ITarget target = new EmployeeAdapter();
            //Console.WriteLine("HR system passes employee string array to Adapter\n");
            //target.ProcessCompanySalary(employeesArray);
            #endregion program1

            #region program2
            Console.WriteLine("Translator");
            string replyFromDavid = new EnglishSpeaker().AskQuestion("how are you?");
            Console.WriteLine("Reply From David [French Speaker can Speak and Understand only French] :  " + replyFromDavid);
            Console.WriteLine();
            string replyFromJohn = new FrenchSpeaker().AskQuestion("où êtes-vous?");
            Console.WriteLine("Reply From John [English Speaker can Speak and Understand only English] :  " + replyFromJohn);
            #endregion program2

            Console.Read();
        }
    }
}
