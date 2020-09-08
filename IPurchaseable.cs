namespace SalesTax
{
    public interface IPurchaseable
    {
        int Quantity { get; set; }
        string Name { get; set; }
        string At { get; set; }
        decimal Price { get; set; }

        bool isTaxable { get; set; }
        bool isImport { get; set; }
        decimal GetPrice();
        decimal GetTaxAmt();
    }
}