using BuilderPattern.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Abstract_builder
{
    public abstract class BeverageBuilder
    {
        protected Beverage _beverage;

        public void CreateBeverage()
        {
            _beverage = new Beverage();
        }

        public Beverage GetBeverage()
        {
            return _beverage;
        }

        public abstract void SetBeverageType();
        public abstract void SetWater();
        public abstract void SetMilk();
        public abstract void SetSugar();
        public abstract void SetPowderQuantity();

    }
}
