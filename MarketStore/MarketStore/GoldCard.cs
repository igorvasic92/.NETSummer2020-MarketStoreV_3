using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    class GoldCard : IDiscountCardType
    {
        public string Name => "Gold";

        public double InitialDiscountRate => 0.02;

        public double DiscountRate(double Turnover)
        {
            return System.Math.Min(0.10, InitialDiscountRate + 0.01 * Turnover / 100);
        }

        public DiscountCalculator DiscountCalculator => new DiscountCalculator();

    }
}
