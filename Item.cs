namespace SalesTax
{
    public class Item : IPurchaseable
    {
        public string Name { get; set; }
        public string At { get; set; }
        public decimal Price { get; set; }
        public bool isTaxable { get; set; }
        public bool isImport { get; set; }
        public Item(string aName, string aAt, decimal aPrice, bool aisTaxable)
        {
            Name = aName;
            At = aAt;
            Price = aPrice;
            isTaxable = aisTaxable;
            if (Name.Contains("Imported"))
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
            return 0;
        }
    }
}