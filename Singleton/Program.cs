using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    //public sealed class Singleton
    //{
    //    private Singleton()
    //    {

    //    }

    //    private static Singleton _instance;
    //    private static readonly object padlock = new object();

    //    public static Singleton GetInstance()
    //    {
    //        if (_instance == null)
    //        {
    //            _instance = new Singleton();
    //        }
    //        return _instance;
    //    }

    //}

    class Program
    {
        static WaiterAllotment get1 = WaiterAllotment.GetWaiterInstance();
        static WaiterAllotment get2 = WaiterAllotment.GetWaiterInstance();
        static void Main(string[] args)
        {
            //Singleton s1 = Singleton.GetInstance();
            //Singleton s2 = Singleton.GetInstance();
            //if (s1 == s2)
            //{
            //    Console.WriteLine("Both have same instance..");
            //}
            //else { 
            //Console.WriteLine("failed...");
            //}

            for (int i = 0; i < 10; i++)
            {
                host1Table();
                host2Table();    
            }
            Console.ReadLine();
        }

        private static void host1Table()
        {
            Console.WriteLine("The next waiter : "+ get1.GetNextWaiter());
        }
        
        private static void host2Table()
        {
            Console.WriteLine("The next waiter : "+ get2.GetNextWaiter());
        }
    }
}
