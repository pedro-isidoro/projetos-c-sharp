using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course6.OSEntities;
using Course6.OSEntities.Enums;
using Course6.PostEntities;

namespace Course6.OSEntities
{
    internal class Order
    {
        DateTime Moment { get; set; }
        OS Status { get; set; }
        List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }



        public Order()
        {
        }

        public Order(DateTime moment, OS status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Summary:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString());
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append(" (");
            sb.Append(Client.BirthDate);
            sb.Append(") - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.Append(item.Product.Name);
                sb.Append(", R$");
                sb.Append(item.Price.ToString("F2", CultureInfo.InvariantCulture));
                sb.Append(", Quantity: ");
                sb.Append(item.Quantity);
                sb.Append(", Subtotal: R$");
                sb.Append(item.SubTotal().ToString("F2", CultureInfo.InvariantCulture));
                sb.AppendLine();
            }

            sb.Append("Total price: R$");
            sb.AppendLine(Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

    }
}
