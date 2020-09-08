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
                Console.WriteLine($"{MyCart[i].Quantity} {MyCart[i].Name} at {MyCart[i].Price}");
            }
        }
        public List<string> CheckOut(List<IPurchaseable> myCart)
        {
            // [x] Receive myCart list and loop through to get price
            // [x] nest f(x) call to calculate tax/import if item requires
            decimal total = 0.00M;
            decimal totalSansTax = 0.00M;
            List<string> myReceipt = new List<string>();
            foreach (IPurchaseable item in myCart)
            {
                decimal itemPrice = item.Price * item.Quantity;
                totalSansTax += itemPrice;
                decimal price = item.GetPrice();
                total += price;
                string formatItem = "";
                // [] if Quantity or next item has same name then format together
                if (item.Quantity > 1)
                {
                    // [] if multiple items, format: Name: Price (# @ CalculatedPrice)
                    formatItem = $"{item.Name}: ({item.Quantity} there should be more here)";
                }
                else
                {
                    // [x] format string: Name: Price
                    formatItem = $"{item.Name}: {price}";
                    // [x] add formatted string to list myReceipt
                    myReceipt.Add(new string(formatItem));
                }
            }
            // [x] after looping item list, add to receipt the sales tax total
            decimal SalesTax = total - totalSansTax;
            myReceipt.Add(new string($"Sales Taxes: {SalesTax}"));
            // [x] add last to list the grand total price
            myReceipt.Add(new string($"Total: {total}"));
            // return decimal.Round(total, 2);
            // [x] return list of strings formatted as myReceipt
            return myReceipt;
        }
    }
}