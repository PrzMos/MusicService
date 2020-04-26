using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.OrderEqupments
{
    // Think about how it has to work!!
    public abstract class Order
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public double FullPrice { get; set; }
        // add prop to type of payment - State Pattern, prop of what kind of monetary - enum is used,
        // maybe use enum for that or maybe State Pattern
    }
}
