using System;
using System.Collections.Generic;

namespace SalesTax
{
    class Program
    {
        static void Main(string[] args)
        {
            ShoppingBasket basket1 = new ShoppingBasket();
            List<string> myReceipt = basket1.CheckOut(basket1.MyCart);
            basket1.Print(myReceipt);
        }
    }
}
