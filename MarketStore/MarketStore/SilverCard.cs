using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class SilverCard : IDiscountCardType
    {
        public string Name => "Silver";

        public double InitialDiscountRate => 0.02;

        public double DiscountRate(double Turnover)
        {
            if (Turnover > 300)
            { return 0.035; }
            else return InitialDiscountRate;
        }

        public DiscountCalculator DiscountCalculator => new DiscountCalculator();
    }
}
