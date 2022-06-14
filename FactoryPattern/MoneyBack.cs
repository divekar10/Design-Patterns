using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class MoneyBack : ICreditCard
    {
        public string CardType()
        {
            return "Money Back";
        }

        public int GetAnnualCharge()
        {
            return 200;
        }

        public int GetCreditLimit()
        {
            return 50000;
        }
    }
}
