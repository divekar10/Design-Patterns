using BuilderPattern.Abstract_builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Concrete_Builder
{
    public class CoffeeBuilder : BeverageBuilder
    {
        public override void SetBeverageType()
        {
            _beverage.BeverageName = "Coffee";
        }

        public override void SetMilk()
        {
            Console.WriteLine("Adding Milk...");
            _beverage.Milk = 50;
            Console.WriteLine("Milk added...");
        }

        public override void SetPowderQuantity()
        {
            Console.WriteLine("Adding 15 Grams of coffee powder...");
            _beverage.PowerQuantity = 15;
            Console.WriteLine("coffee powder added");
        }

        public override void SetSugar()
        {
            Console.WriteLine("Adding Sugar...");
            _beverage.Sugar = 10;
            Console.WriteLine("Sugar added...");
        }

        public override void SetWater()
        {
            Console.WriteLine("Boiling Water...");
            _beverage.Water = 40;
        }
    }
}
