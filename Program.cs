﻿using System;
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
            // [] Input ShoppingBasket: List of Dictionaries
            // [] Interface Sales Tax add 10%
            //  [] Exception are books, food, and medical products
            // [] Interface Import tax add 5%, no exceptions

            // ShoppingBasket will ask user what items to put in their basket
            ShoppingBasket basket1 = new ShoppingBasket();
        }
    }
}