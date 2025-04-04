using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Course2
{
    internal class Currency
    {
        public double Cotation;
        public double Quantity;

        public double TotalInReais()
        {
            double total =  Quantity * Cotation;
            return total += (0.06 * total);
        }
        public override string ToString()
        {
            return "Valor a ser pago em reais = "
                + TotalInReais().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
