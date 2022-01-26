using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Cart
    {
        public List<Products> _cart { get; set; } = new List<Products>();

        public void AddProduct(Products product)
        {
            _cart.Add(product);
        }

        private void DisplayCart(Products product)
        {
            Console.WriteLine("---------------------------------------");
            product.Display();
            Console.WriteLine("---------------------------------------\n\n");
        }
      
        private void DisplayCartDetails(List<Products> product)
        {
            foreach (var products in product)
            {
                DisplayCart(products);
            }
        }

        public void DisplayAllProfuctsOnList()
        {
            Console.WriteLine("\t\tAll products:\t\t");

            DisplayCartDetails(_cart);            
        }
        //Method for printing all products in Cart
        public void DisplayProductsInCart(double[] arr)
        {           
            var isAllZero = true;
            foreach (var value in arr)
            {
                if (value != 0)
                {
                    isAllZero = false;
                    break;
                }
            }
            if (isAllZero)
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Cart is empty.... Press 2 to add products.");
                Console.WriteLine("----------------------------");
            }
            else
            {
                Console.WriteLine("----------------------------");
                Console.WriteLine("Products in cart:");
                Console.WriteLine("----------------------------");
                int i = 0;
                foreach (var products in _cart)
                {
                    if(arr[i] != 0){ 
                    Console.WriteLine($"\t{arr[i]} x {products.name}"); }
                    i++;
                }
                Console.WriteLine("----------------------------");
            }
        }
    }
}
