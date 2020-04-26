using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Domain.OrdersItems
{
    public class OrderItemsTest
    {
        private readonly Guid Id = new Guid();
        private readonly int OrderId = 1;
        private readonly int Quantity = 10;
        private readonly double DetailedPrice = 4.3;

        [Fact]
        public void GivenId_ShouldReturnTrue()
        {
            OrderItems orderItems = new OrderItems();

            orderItems.Id = Id;

            Assert.Equal(Id, orderItems.Id);
        }

        [Fact]
        public void GivenQuantityAndDetailedPrice_CalculateFullDetailedPrice_ShouldReturnTrue()
        {
            OrderItems orderItems = new OrderItems();
            double expected = 43;

            orderItems.Quantity = Quantity;
            orderItems.DetailedPrice = DetailedPrice;

            Assert.Equal(expected, orderItems.FullDetailedPrice);
        }
    }
}
