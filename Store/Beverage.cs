using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Beverage : Products
    {
        public DateTime expirationDate;

        //Beverage class constructor
        public Beverage(string name, string brand, double price, DateTime exp) : base(name, brand, price)
        {          
            this.expirationDate = exp;
        }
        //Override method for printing Beverage object information
        public override void Display()
        {
            string expDate2 = expirationDate.ToString("yyyy-MM-dd");
            Console.WriteLine($"Name: {name}\nBrand: {brand}\nPrice: ${price}\nExpiration Date: {expDate2}\n");
        }
        //Override method for calculating discount
        public override double calculateDiscount(double count, DateTime purchaseDate)
        {           
            double discountSum = 0;
            int beverageExpirationDate = (expirationDate - purchaseDate).Days;

            double factor = (beverageExpirationDate == 0) ? 0.5 : (beverageExpirationDate <= 5 ? 0.1 : 0);

            double beverageDiscount = price * factor;
            discountSum += beverageDiscount * count;
            if (factor > 0)
            {
                Console.WriteLine("#discount {0}% -${1:F2}", factor * 100, beverageDiscount * count);
            }
            return discountSum;
        }
    }
}
