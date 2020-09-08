using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            OrderItemId = orderItemId;
        }
        public int OrderItemId { get; private set; }
        public decimal? PurchasePrice { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }
        public bool Save()
        {
            return true;
        }
        public bool Validate()
        {
            var isvalid = true;

            if (Quantity <= 0) isvalid = false;
            if (ProductId <= 0) isvalid = false;
            if (PurchasePrice == null) isvalid = false;
            return isvalid;
        }

    }
}
