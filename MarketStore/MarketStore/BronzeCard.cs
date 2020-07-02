using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class BronzeCard : IDiscountCardType
    {
        public string Name => "Bronze";

        public double InitialDiscountRate => 0;

        public double DiscountRate(double Turnover)
        {
            if (Turnover <= 100 & Turnover >= 300)
            { return 0.01; }
            else if (Turnover > 300)
            { return 0.025; }
            else return InitialDiscountRate;
        }
        public DiscountCalculator DiscountCalculator => new DiscountCalculator();
        


    }
}
