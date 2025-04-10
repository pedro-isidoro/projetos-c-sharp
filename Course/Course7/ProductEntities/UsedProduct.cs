using System;

namespace Course7.ProductEntities
{
    internal class UsedProduct : Product
    {
        public DateTime Date { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime date)
            : base(name, price)
        {
            Date = date;
        }

        public override string PriceTag()
        {
            return $"{Name} (used), $ {Price.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)} (Manufacture Date: {Date.ToString("dd/MM/yyyy")})";
        }
    }

}
