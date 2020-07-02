using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public interface IDiscountCardType
    {
        public string Name { get;}
        public double InitialDiscountRate { get;}
        public double DiscountRate(double Turnover);
        public DiscountCalculator DiscountCalculator { get; }
    }
}
