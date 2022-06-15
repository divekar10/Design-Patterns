using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Factory done using Abstract Factory design pattern.\n");
            Client client = new Client();
            Console.WriteLine("Enter car name : ");
            string carName = Console.ReadLine();
            client.CreateCarWithLight(carName);
            Console.ReadLine();
        }
    }
}
