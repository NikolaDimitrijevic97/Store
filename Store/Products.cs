using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Products
    {
        public string name;
        public string brand;
        public double price;

        //Products class constructor
        public Products(string name, string brand,double price)
        {
            this.name = name;
            this.brand = brand;
            this.price = price;
        }

        //Virtual method for printing Products object information
        public virtual  void Display()
        {           
            Console.WriteLine($"Name: {name}\nBrand: {brand}\nPrice: {price}");
        }
        //Virtual method for calculating discount
        public virtual double calculateDiscount (double count, DateTime purchaseDate) { return 0; }
       
    }
}
