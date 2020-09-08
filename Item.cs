using System;

namespace SalesTax
{
    public class Item : IPurchaseable
    {
        public int Quantity { get; set; }
        public string Name { get; set; }
        public string At { get; set; }
        public decimal Price { get; set; }
        public bool isTaxable { get; set; }
        public bool isImport { get; set; }
        public Item(int aQuantity, string aName, string aAt, decimal aPrice, bool aisTaxable)
        {
            Quantity = aQuantity;
            Name = aName;
            At = aAt;
            Price = aPrice;
            isTaxable = aisTaxable;
            if (Name.ToLower().Contains("imported"))
            {
                isImport = true;
            }
            else
            {
                isImport = false;
            }
        }
        public decimal GetPrice()
        {
            Price *= Quantity;
            Price += GetTaxAmt();
            return decimal.Round(Price, 2);
        }
        public decimal GetTaxAmt()
        {
            decimal TaxRate = 0.10M;
            decimal ImportRate = 0.05M;
            decimal Calculate = 0.00M;
            if (isTaxable)
            {
                Calculate += Math.Round(Price * TaxRate) * 20 / 20;
            }
            if (isImport)
            {
                Calculate += Math.Round(Price * ImportRate) * 20 / 20;
            }
            return decimal.Round(Calculate, 2);
        }
    }
}