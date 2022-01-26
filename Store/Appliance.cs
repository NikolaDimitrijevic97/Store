using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Appliance : Products
    {
        public string model;
        public DateTime productionDate;
        public double weight;

        //Appliance class constructor
        public Appliance(string name,string brand,double price,string model, DateTime date, double weight) : base(name, brand, price)
        {
            this.model = model;
            this.productionDate = date;
            this.weight = weight; 
        }

        //Override method for printing Appliance object information
        public override void Display()
        {
            string productionDate1 = productionDate.ToString("yyyy-MM-dd");
            Console.WriteLine($"Name: {name}\nBrand: {brand}\nPrice: ${price}\nModel: {model}\nProduction Date: {productionDate1}\nWeight: {weight}\n");
        }
        //Override method for calculating discount
        public override double calculateDiscount(double count, DateTime purchaseDate)
        {
            int dayOfTheWeek = ((int)purchaseDate.DayOfWeek + 6) % 7 + 1;
            double discountSum = 0;
            if (dayOfTheWeek > 5 && price > 999)
            {

                double applianceDiscount = (price * 5) / 100.0;
                discountSum += applianceDiscount * count;
                Console.WriteLine("#discount 5% -${0:F2}", applianceDiscount * count);
            }
            return discountSum; 
        }
    }
}
