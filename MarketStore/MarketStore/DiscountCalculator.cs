using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class DiscountCalculator
    {
        public double DiscountRateInPercentage(IDiscountCardType cardType, double turnover)
        {
            return 100 * cardType.DiscountRate(turnover);
        }

        public double TotalDiscount(IDiscountCardType cardType, double purchasePrice, double turnover)
        {
            return purchasePrice * cardType.DiscountRate(turnover);
        }

        public double TotalPriceWithDiscount(IDiscountCardType cardType, double purchasePrice, double turnover)
        {
            return purchasePrice - TotalDiscount(cardType, purchasePrice, turnover);
        }
    }
}
