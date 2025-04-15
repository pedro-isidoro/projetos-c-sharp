using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentExercice.Entities
{
    internal interface IPayable
    {
        double GetPayment();
    }
}
