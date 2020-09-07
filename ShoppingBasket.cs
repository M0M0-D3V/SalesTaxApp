using System;
using System.Collections.Generic;

namespace SalesTax
{
    public class ShoppingBasket
    {
        // Will contain objects shopper will purchase
        public List<IPurchaseable> MyCart;
        // constructor, get customer list
        public ShoppingBasket()
        {
            MyCart = new List<IPurchaseable>();
            // [x] Console.ReadLine() a bunch of questions to get what user is buying
            // [x] Ask User how many items they are buying and set that int as number of loops.
            int NumItems;
            Console.WriteLine("Total number of items purchasing?: ");
            NumItems = Convert.ToInt32(Console.ReadLine());

            // [x] loop through mylist and check if item is taxable
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
                int Quantity;
                Console.WriteLine("Enter how many of this product: ");
                Quantity = Convert.ToInt32(Console.ReadLine());
                decimal Price;
                Console.WriteLine("Enter price of item: ");
                Price = Convert.ToDecimal(Console.ReadLine());
                string yesorno;
                bool isTaxable = true;
                Console.WriteLine("Is the product a Book, Food, or Medical Product? (Y/N): ");
                yesorno = Console.ReadLine();
                if (yesorno.ToLower() == "y")
                {
                    isTaxable = false;
                }
                MyCart.Add(new Item(Quantity, Name, "At", Price, isTaxable));
                Console.WriteLine($"MyCart has now: {MyCart[i].Name}, {MyCart[i].Price}, Taxable:{MyCart[i].isTaxable}");
            }
            for (int i = 0; i < NumItems; i++)
            {
                Console.WriteLine($"MyCart Item {i} is: {MyCart[i].Name} - {MyCart[i].Price}");
            }
        }
        public decimal CheckOut(List<IPurchaseable> myCart)
        {
            // [] Receive myCart list and loop through to get price
            // [] nest f(x) call to calculate tax/import if item requires
            decimal total = 0.00M;
            foreach (IPurchaseable item in myCart)
            {
                total += item.GetPrice();
            }
            return decimal.Round(total, 2);
        }
    }
}