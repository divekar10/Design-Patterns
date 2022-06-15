using BuilderPattern.Abstract_builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BuilderPattern.Concrete_Builder
{
    public class TeaBuilder : BeverageBuilder
    {
        public override void SetBeverageType()
        {
            _beverage.BeverageName = "Tea";
        }

        public override void SetMilk()
        {
            Thread.Sleep(1000);
            Console.WriteLine("Adding Milk...");
            _beverage.Milk = 50;
            Thread.Sleep(2000);
            Console.WriteLine("Milk Added...");
        }

        public override void SetPowderQuantity()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Adding 15 Grams of tea powder...");
            _beverage.PowerQuantity = 15;
            Thread.Sleep(2000);
            Console.WriteLine("tea powder added...");
            Thread.Sleep(2000);

        }

        public override void SetSugar()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Adding Sugar...");
            _beverage.Sugar = 10;
            Thread.Sleep(2000);
            Console.WriteLine("Sugar Added...");
        }

        public override void SetWater()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Boiling Water...");
            _beverage.Water = 40;
            Thread.Sleep(2000);
        }
    }
}
