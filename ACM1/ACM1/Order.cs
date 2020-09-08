using System;
using Acme.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM1
{
    public class Order : EntityBase, ILoggable
    {
        public Order() : this(0)
        {

        }
        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();

        }
        public int CustomerId { get; set; }
        public int ShippingAddressId { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        public override string ToString() =>
            $"{OrderDate.Value.Date}({OrderId})";

        public string Log()
        {
            var logString = OrderId + ": " +
                "Date :" + OrderDate + " ";
            //"Status :" + EntityState.ToString();
            return logString;
        }


        /*public Order Retrieve(int orderId)
        {
            return new Order();
        }
        public bool Save()
        {
            return true;
        }*/
        public override bool Validate()
        {
            var isvalid = true;
            if (OrderDate == null) isvalid = false;
            return isvalid;

        }


    }
}
