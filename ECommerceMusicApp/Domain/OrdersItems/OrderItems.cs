using Domain.OrderEqupments;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain.OrdersItems
{
    public class OrderItems
    {
        public Guid Id { get; set; }
        public int OrderId { get; set; }
        public Order Order{ get; set; }
        public int Quantity { get; set; }
        public double DetailedPrice { get; set; }
        [NotMapped]
        public double FullDetailedPrice { get; set; }
        public OrderItems()
        {
            if (Quantity != 0 && DetailedPrice != 0)
            {
                FullDetailedPrice = GetFullDetailedPrice();
            }
        }

        private double GetFullDetailedPrice()
        {
            return Quantity * DetailedPrice;
        }
    }
}
