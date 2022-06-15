using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Product
{
    public class Beverage
    {
        public int Water { get; set; }
        public int Milk { get; set; }
        public int Sugar { get; set; }
        public int PowerQuantity { get; set; }
        public string BeverageName { get; set; }

        public string ShowBeverage()
        {
            return $"Hot {BeverageName} [ {Water} ml of water, {Milk} ml of milk, {Sugar} gm of sugar, {PowerQuantity} gm of {BeverageName} ]";
        }
    }
}
