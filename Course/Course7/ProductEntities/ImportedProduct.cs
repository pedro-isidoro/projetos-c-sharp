using System;
using System.Globalization;


namespace Course7.ProductEntities
{
    internal class ImportedProduct : Product
    {
        public double CustomFee { get; set; }

        public ImportedProduct() { 
        }

        public ImportedProduct(string name, double price, double customFee) 
            : base(name, price)
        {
            CustomFee = customFee;
        }

        public override string PriceTag()
        {
            return $"{Name}, $ {TotalPrice().ToString("F2", CultureInfo.InvariantCulture)} (Custom Fee: $ {CustomFee})";
        }

        public double TotalPrice()
        {
            return Price + CustomFee;
        }

    }
}
