using System;
using System.Collections.Generic;
namespace SalesTax
{
    public class ShoppingBasket
    {
        public List<IPurchaseable> MyCart;
        public ShoppingBasket()
        {
            MyCart = new List<IPurchaseable>();
            int NumItems;
            Console.WriteLine("Total number of items purchasing?: ");
            NumItems = Convert.ToInt32(Console.ReadLine());
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
            }
            for (int i = 0; i < NumItems; i++)
            {
                Console.WriteLine($"{MyCart[i].Quantity} {MyCart[i].Name} at {MyCart[i].Price}");
            }
        }
        public List<string> CheckOut(List<IPurchaseable> myCart)
        {
            decimal total = 0.00M;
            decimal totalSansTax = 0.00M;
            List<string> myReceipt = new List<string>();
            foreach (IPurchaseable item in myCart)
            {
                decimal itemPrice = item.Price * item.Quantity;
                totalSansTax += itemPrice;
                total += item.GetPrice();
                string formatItem = "";
                if (item.Quantity > 1)
                {
                    formatItem = $"{item.Name}: {item.Price} ({item.Quantity} @ {item.Price + item.GetTaxAmt()})";
                }
                else
                {
                    formatItem = $"{item.Name}: {item.GetPrice()}";
                }
                myReceipt.Add(new string(formatItem));
            }
            decimal SalesTax = total - totalSansTax;
            myReceipt.Add(new string($"Sales Taxes: {SalesTax}"));
            myReceipt.Add(new string($"Total: {total}"));
            return myReceipt;
        }
        public void Print(List<string> myReceipt)
        {
            Console.WriteLine($"*********-PRINTING RECEIPT-*********");
            foreach (string item in myReceipt)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"************-THANK YOU-*************");
        }
    }
}