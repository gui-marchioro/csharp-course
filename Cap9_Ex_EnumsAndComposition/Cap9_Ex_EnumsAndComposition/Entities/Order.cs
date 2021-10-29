using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cap9_Ex_EnumsAndComposition.Entities.Enums;

namespace Cap9_Ex_EnumsAndComposition.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Customer { get; set; }
        public List<OrderItem> orderItems = new List<OrderItem>();

        public Order()
        {
        }

        public Order(Client customer, DateTime moment, OrderStatus status)
        {
            Customer = customer;
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {
            orderItems.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            orderItems.Remove(item);
        }
        public double Total()
        {
            double total = 0;
            foreach(OrderItem item in orderItems)
            {
                total += item.SubTotal();
            }
            return total;
        }
        public override string ToString()
        {
            StringBuilder returnString = new StringBuilder();
            returnString.AppendLine("\nORDER SUMMARY");
            returnString.Append("Order moment: ");
            returnString.AppendLine(Moment.ToString());
            returnString.Append("Order status: ");
            returnString.AppendLine(Status.ToString());
            returnString.Append("Client: ");
            returnString.AppendLine(Customer.ToString());
            returnString.AppendLine("Order items:");
            foreach(OrderItem item in orderItems)
            {
                returnString.AppendLine(item.ToString());
            }
            returnString.Append("Total price: $");
            returnString.AppendLine(Total().ToString());
            return returnString.ToString();
        }
    }
}
