using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class WaiterAllotment
    {
        private static readonly WaiterAllotment _instance = new WaiterAllotment();
        private List<string> waiters = new List<string>();
        private int nextWaiter = 0;
        public WaiterAllotment()
        {
            waiters.Add("John");
            waiters.Add("Mary");
            waiters.Add("Bob");
            waiters.Add("Sam");
            waiters.Add("Danny");
            waiters.Add("Julia");
        }

        public static WaiterAllotment GetWaiterInstance()
        {
            return _instance;
        }

        public string GetNextWaiter()
        {
            string output = waiters[nextWaiter];
            nextWaiter += 1;

            if (nextWaiter >= waiters.Count)
            {
                nextWaiter = 0;   
            }
            return output;
        }
    }
}
