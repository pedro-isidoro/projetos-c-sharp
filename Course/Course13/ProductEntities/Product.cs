﻿using System.Globalization;
namespace Course13.ProductEntities
{
	public class Product
	{
		public string Name { get; set; }
		public double Price { get; set; }

		public Product(string name, double price)
		{
			Name = name;
			Price = price;
		}

        public override string ToString()
        {
			return $"{Name}, R${Price.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

