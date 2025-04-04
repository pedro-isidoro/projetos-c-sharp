using System;
using System.Globalization;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course3
{
    internal class PropertiesProduct
    {
        /*
        private string _name;
        private double _price;
        private int _qtt;
        */
        //Agora com auto-propertie
        private string _name;
        public double Price { get; private set; }
        public int Qtt { get; private set; }

        public PropertiesProduct()
        {
        }

        public PropertiesProduct(string nome, double price, int qtt)
        {
            _name = nome;
            /*_price = price;
            _qtt = qtt;*/
            Price = price;
            Qtt = qtt;
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }

        /*
         * Para properties normaais, não para as auto-properties
         * public double Price
        {
            get { return _price; }
        }

        public double Qtt
        {
            get { return _qtt; }
        }*/

        public double TotalValueInStorage()
        {
            //return _price * _qtt;
            return Price * Qtt;
        }

        public void AddProduct(int quantity)
        {
            //_qtt += quantity;
            Qtt += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            //_qtt -= quantity;
            Qtt += quantity;
        }

        public override string ToString()
        {
            /*return _name
                + " $"
                + _price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _qtt
                + " unidades, Total: $ "
                + TotalValueInStorage().ToString("F2", CultureInfo.InvariantCulture);*/
            return _name
                + " $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Qtt
                + " unidades, Total: $ "
                + TotalValueInStorage().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
