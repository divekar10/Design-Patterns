using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Platinum : ICreditCard
    {
        public string CardType()
        {
            return "Platinum";
        }

        public int GetAnnualCharge()
        {
            return 500;
        }

        public int GetCreditLimit()
        {
            return 100000;
        }
    }
}
