using System;
using System.Collections.Generic;

namespace SalesTax
{
    class Program
    {
        static void Main(string[] args)
        {
            // WRITE AN APP THAT TAKES INPUT FOR SHOPPING BASKETS AND RETURNS RECEIPTS IN THE FORMAT, CALCULATING ALL TAXES AND TOTALS CORRECTLY.
            // WHEN CALCULATING PRICES PLUS TAx, ROUND THE TOTAL UP TO THE NEAREST 5 CENTS.
            // e.g. if taxable item costs $5.60, an exact 10% would be $0.56, and the final price after adding the rouded tax of $0.60 should be $6.20.
            //  this means tax is rounded from $0.56 to $0.60

            // STEPS TO BUILD:
            // [x] Input ShoppingBasket: List of Dictionaries
            // [] Interface Sales Tax add 10%
            //  [x] Exception are books, food, and medical products
            // [] Interface Import tax add 5%, no exceptions
            // [] Implement "CheckOut" Method from ShoppingBasket

            // ShoppingBasket will ask user what items to put in their basket
            ShoppingBasket basket1 = new ShoppingBasket();
            Console.WriteLine($"back to program and basket1 now has: {basket1.MyCart.Count} items");

            decimal totalCost = basket1.CheckOut(basket1.MyCart);
            Console.WriteLine($"Total cost is now: {totalCost}");
            // var Receipt = basket1.
        }
    }
}
