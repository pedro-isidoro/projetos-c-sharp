using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Course3
{
    internal class PrivateProduct
    {
        //Isso é um encapsulamento, onde torno os valores privado
        //EastAsianLunisolarCalendar apenas setados com um método, caso permitido
        private string _name;
        private double _price;
        private int _qtt;

        public PrivateProduct() { 
        }

        public PrivateProduct(string nome, double price, int qtt)
        {
            _name = nome;
            _price = price;
            _qtt = qtt;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name) { 
            if(name != null && name.Length > 1)
            {
                _name = name;
            }
        }

        public double GetPrice() {
            return _price;
        } 
        
        public double GetQtt() {
            return _qtt;
        }

        public double TotalValueInStorage()
        {
            return _price * _qtt;
        }

        public override string ToString()
        {
            return _name
                + " $"
                + _price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _qtt
                + " unidades, Total: $ "
                + TotalValueInStorage().ToString("F2", CultureInfo.InvariantCulture);
        }

        public void AddProduct(int quantity)
        {
            _qtt += quantity;
        }

        public void RemoveProduct(int quantity)
        {
            _qtt -= quantity;
        }
    }
}
