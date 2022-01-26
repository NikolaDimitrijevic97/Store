using System;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("Welcome to our store\n");
            Console.WriteLine("Select operation:");
            Console.WriteLine("1. Products list");
            Console.WriteLine("2. Buy Products");
            Console.WriteLine("3. Cart");
            Console.WriteLine("4. Receipt");
            Console.WriteLine("x  Exit");
            var userInput = Console.ReadLine();

            //Creating Food object
            DateTime a = new DateTime(2021,06,14);
            string expDate1 = a.ToString("yyyy-MM-dd");       
            Food objectFood=new Food("Apple","BrandA",1.50, a);          

            //Creating Beverage object
            DateTime expDate2 = new DateTime(2022,01,30);           
            Beverage objectBeverage = new Beverage("Milk", "BrandM", 0.99, expDate2);

            //Creating  Clothes object
            Clothes objectClothes = new Clothes("T-shirt","BrandT",15.99,"M","Violet");

            //Creating  Appliance object
            DateTime productionDate = new DateTime(2021,03,03);            
            Appliance objectAppliance = new Appliance("Laptop", "BrandL", 2345, "ModelL",productionDate, 1.125);

            //Creating  Cart object
            Cart newCart = new Cart();

            //Adding objects to a list
            newCart.AddProduct(objectFood);          
            newCart.AddProduct(objectBeverage);
            newCart.AddProduct(objectClothes);
            newCart.AddProduct(objectAppliance);

            //Number of purchased products
            int count = newCart._cart.Count;
            double[] numbersOfProducts = new double[count];
          
            while (true)
            {               
                switch (userInput)
                {                    
                    case "1":
                        newCart.DisplayAllProfuctsOnList();
                        break;
                    case "2":
                        Console.WriteLine("Enter the amount of product:");
                        for (int i = 0; i < count; i++)
                        {
                            Console.Write($"{newCart._cart[i].name}:");
                            numbersOfProducts[i] = Convert.ToDouble(Console.ReadLine());
                        }                      
                        break;
                    case "3":
                        newCart.DisplayProductsInCart(numbersOfProducts);
                        break;
                    case "4":
                        Cashier objectCashier = new Cashier();
                        objectCashier.Receipt(newCart._cart, numbersOfProducts);                        
                        break;
                    case "x": return;                      
                    default:
                        Console.WriteLine("Select right operation");
                        break;
                }
                Console.WriteLine("\nSelect new operation:");
                Console.WriteLine("1. Products list");
                Console.WriteLine("2. Buy Products");
                Console.WriteLine("3. Cart");
                Console.WriteLine("4. Receipt");
                Console.WriteLine("x  Exit");                              
                userInput = Console.ReadLine();
            }
        }
    }
}
