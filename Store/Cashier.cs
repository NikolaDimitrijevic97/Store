using System;
using System.Collections.Generic;
using System.Text;

namespace Store
{
    class Cashier : Cart
    {   
        //Purchase Date
        public DateTime purchaseDate =new DateTime(2021,06,14,12,34,56);


        //Receipt printing
        public void  Receipt(List<Products> cart, double[] arr)
        {   
            int count = 0;
            double discountSum = 0;
            double sum = 0;
            string dateFormat = purchaseDate.ToString("yyyy-MM-dd HH:mm:ss");
            Console.Clear();
            Console.WriteLine($"\nDate: {dateFormat}\n");
            Console.WriteLine("---Products---");

            foreach (Products p in cart)
            {               
                if (arr[count] != 0)
                {
                    sum += p.price*arr[count];
                    Console.WriteLine("\n\n{0} - {1}\n{2} x {3} = ${4:F2}",p.name, p.brand, arr[count], p.price, arr[count] * p.price);
                    discountSum += p.calculateDiscount(arr[count], purchaseDate);              
                }
                count++;            
            }
            Console.WriteLine("\n-----------------------------------------------------------------------------------");
            Console.WriteLine("SUBTOTAL: ${0:F2}",sum);
            if (discountSum != 0)
            {
                Console.WriteLine("DISCOUNT: -${0:F2}", discountSum);
                Console.WriteLine("\nTOTAL: ${0:F2}", sum - discountSum);
            }
            else
            {
                Console.WriteLine($"\nTOTAL: ${sum:F2}");
            }        
        }
    }
}
