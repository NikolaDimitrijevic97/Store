using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Clothes : Products
    {
        public string size;
        public string color;

        //Clothes class constructor
        public Clothes(string name, string brand, double price, string size,string color) : base(name, brand, price)
        {           
            this.size = size;
            this.color = color;
        }
        //Override method for printing Clothes object information
        public override void Display()
        {
            Console.WriteLine($"Name: {name}\nBrand: {brand}\nPrice: ${price}\nSize: {size}\nColor: {color}\n");
        }
        //Override method for calculating discount
        public override double calculateDiscount(double count, DateTime purchaseDate) 
        {
            int dayOfTheWeek = ((int)purchaseDate.DayOfWeek + 6) % 7 + 1;
            double discountSum = 0;
            if (dayOfTheWeek <= 5)
            {
                double clothesDiscount = (price * 10) / 100.0;
                discountSum += clothesDiscount * count;
                Console.WriteLine("#discount 10% -${0:F2}", clothesDiscount * count);
            }
            return discountSum;            
        }
    }
}
