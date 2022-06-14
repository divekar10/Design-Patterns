using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Titanium : ICreditCard
    {
        public string CardType()
        {
            return "Titanium";
        }

        public int GetAnnualCharge()
        {
            return 700;
        }

        public int GetCreditLimit()
        {
            return 150000;
        }
    }
}
