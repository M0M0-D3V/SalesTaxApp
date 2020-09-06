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
                Console.WriteLine("Enter name of product: ");
                Name = Console.ReadLine();
                decimal Price;
                Console.WriteLine("Enter price of item: ");
                Price = Convert.ToDecimal(Console.ReadLine());
                string Type;
                Console.WriteLine("Enter type of product (Book, Food, Music, Imported, etc: ");
                Type = Console.ReadLine();

            }

        }
    }
}