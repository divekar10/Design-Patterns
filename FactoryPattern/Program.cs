using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Card Type :");
            string cardType =Console.ReadLine();
            //CardType NewEnum = (CardType) Enum.Parse(typeof(CardType), cardType);
            var isValid = Enum.TryParse<CardType>(cardType,false, out _);
            CardType NewEnum;
            if (isValid)
            {
               NewEnum = (CardType)Enum.Parse(typeof(CardType), cardType);
               ICreditCard creditCard = CreditCardFactory.GetCreditCard(NewEnum);
               Console.WriteLine("Card Type : " + creditCard.CardType());
               Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
               Console.WriteLine("Annual charge : " + creditCard.GetAnnualCharge());
            }
            else 
            { 
            Console.WriteLine("Please enter valid card type..");
            }
            Console.ReadLine();
        }
    }
}
