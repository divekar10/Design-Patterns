using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class CreditCardFactory
    {
        public static ICreditCard GetCreditCard(CardType cardType)
        {
            ICreditCard cardDetails = null;

            switch (cardType)
            {
                case CardType.MoneyBack:
                case CardType.moneyback:
                    cardDetails = new MoneyBack();
                    break;
                case CardType.Platinum:
                case CardType.platinum:
                    cardDetails = new Platinum();
                    break;
                case CardType.Titanium:
                case CardType.titanium:
                    cardDetails = new Titanium();
                    break;
                default:
                    break;
            }
            return cardDetails;
        }
    }
}
