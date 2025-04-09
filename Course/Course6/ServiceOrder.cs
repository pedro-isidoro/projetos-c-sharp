using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course6.Entities.Enums;
using Course6.Entities;

namespace Course6
{
    internal class ServiceOrder
    {
        public void Order()
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine($"Order: {order}");

            //Enum para string
            string txt = OrderStatus.PendingPayment.ToString();
            //String para Enum
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine($"txt: {txt}");
            Console.WriteLine($"os: {os}");
        }
    }
}
