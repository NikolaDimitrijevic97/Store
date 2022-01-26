using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Food : Products
    {
        public DateTime expirationDate;

        //Food class constructor
        public Food(string name, string brand, double price, DateTime exp):base(name,brand,price)
        {            
            this.expirationDate = exp;
        }

        //Override method for printing Food object information
        public override void Display()
        {
            string expDate1 = expirationDate.ToString("yyyy-MM-dd");
            Console.WriteLine($"Name: {name}\nBrand: {brand}\nPrice: ${price}\nExpiration Date: {expDate1}\n");
        }

        //Override method for calculating discount
        public override double calculateDiscount(double count, DateTime purchaseDate)
        {          
            double discountSum = 0;         
            int foodExpirationDate = (expirationDate - purchaseDate).Days;

            double factor = (foodExpirationDate == 0) ? 0.5 : (foodExpirationDate <= 5 ? 0.1 : 0);

            double foodDiscount = price * factor;
            discountSum += foodDiscount * count;
            if (factor > 0)
            {
                Console.WriteLine("#discount {0}% -${1:F2}", factor * 100, foodDiscount * count);
            }
            return discountSum; 
        }
    }
}



