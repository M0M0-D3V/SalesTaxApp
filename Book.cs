namespace SalesTax
{
    public class Book : IPurchaseable
    {
        public string Name { get; set; }
        public string At { get; set; }
        public decimal Price { get; set; }
        public bool isTaxable { get; set; }
        public bool isImport { get; set; }
        public Book(string aName, string aAt, decimal aPrice)
        {
            Name = aName;
            At = aAt;
            Price = aPrice;
            isTaxable = false;
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