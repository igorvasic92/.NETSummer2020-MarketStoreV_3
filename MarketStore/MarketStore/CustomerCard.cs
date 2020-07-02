using System;
using System.Collections.Generic;
using System.Text;

namespace MarketStore
{
    public class CustomerCard
    {
        public int CustomerCardId { get; set; }

        private string firstName;
        public string FirstName 
        {
            get 
            { return firstName; }
            set 
            {
                if (!String.IsNullOrEmpty(value)) { firstName = value; }
                else 
                {
                    throw new ArgumentNullException($"Invalid first name input for customer with Id {CustomerCardId}");
                }
            } 
        }

        private string lastName;
        public string LastName
        {
            get
            { return lastName; }
            set
            {
                if (!String.IsNullOrEmpty(value)) { lastName = value; }
                else
                {
                    throw new ArgumentNullException($"Invalid last name input for customer with Id {CustomerCardId}");
                }
            }
        }

        private double turnover;
        public double Turnover
        {
            get
            { return turnover; }
            set
            {
                if ( value >= 0) { turnover = value; }
                else
                {
                    throw new ArgumentException($"Invalid turnover input for customer with Id {CustomerCardId}");
                }
            }
        }
        public IDiscountCardType CardInfo { get; set; }

        private double purchasePrice;
        public double PurchasePrice
        {
            get
            { return purchasePrice; }
            set
            {
                if (value >= 0) { purchasePrice = value; }
                else
                {
                    throw new ArgumentException($"Invalid purchase price input for customer with Id {CustomerCardId}");
                }
            }
        }
        public double DiscountRate => CardInfo.DiscountRate(Turnover);
        public double DiscountRateInPercentage => CardInfo.DiscountCalculator.DiscountRateInPercentage(CardInfo, Turnover);
        public double TotalDiscount => CardInfo.DiscountCalculator.TotalDiscount(CardInfo, PurchasePrice, Turnover);
        public double TotalPriceWithDiscount => CardInfo.DiscountCalculator.TotalPriceWithDiscount(CardInfo, PurchasePrice, Turnover);
    }
}
