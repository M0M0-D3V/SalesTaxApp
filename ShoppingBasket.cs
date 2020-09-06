using System;
using System.Collections.Generic;

namespace SalesTax
{
    public class ShoppingBasket
    {
        // Will contain objects shopper will purchase
        public List<IPurchaseable> MyCart;
        // constructor, receive list
        public ShoppingBasket()
        {
            // Console.ReadLine() a bunch of questions to get what user is buying
            // Ask User how many items they are buying and set that int as number of loops.
            int NumItems;
            Console.WriteLine("Number of items purchasing?: ");
            NumItems = Convert.ToInt32(Console.ReadLine());

            // loop through mylist and check if item is taxable
            for (int i = 0; i < NumItems; i++)
            {
                string Name;
                if (i == 0)
                {
                    Console.WriteLine("Enter name of product: ");
                }
                else
                {
                    Console.WriteLine("Enter name of next product: ");
                }
                Name = Console.ReadLine();
                decimal Price;
                Console.WriteLine("Enter price of item: ");
                Price = Convert.ToDecimal(Console.ReadLine());
                string yesorno;
                bool isTaxable = true;
                Console.WriteLine("Is the product a Book, Food, or Medical Product? (Y/N): ");
                yesorno = Console.ReadLine();
                if (yesorno == "Y" || yesorno == "y")
                {
                    isTaxable = false;
                }
            }

        }
    }
}