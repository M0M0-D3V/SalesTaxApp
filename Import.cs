namespace SalesTax
{
    public class Import : IPurchaseable
    {
        public string Name { get; set; }
        public string At { get; set; }
        public decimal Price { get; set; }
        public bool isTaxable { get; set; }
        public bool isImport { get; set; }

        public decimal GetPrice()
        {
            return 0;
        }
    }
}