namespace SalesTax
{
    public interface IPurchaseable
    {
        // qty, name, at, price
        string Name { get; set; }
        string At { get; set; }
        decimal Price { get; set; }

        bool isTaxable { get; set; }
        bool isImport { get; set; }
        decimal GetPrice();
    }
}