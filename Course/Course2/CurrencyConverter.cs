using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Course2
{
    internal class CurrencyConverter
    {
        public void Converter() {
            Currency currency = new Currency();

            Console.WriteLine("QualifiedAce as cotação do Dólar?");
            currency.Cotation = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantos Dólares você vai comprar?");
            currency.Quantity = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Valor a ser pago em reais = {currency.TotalInReais().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine(currency);
        }
    }
}
