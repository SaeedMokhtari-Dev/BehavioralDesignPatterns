using System;
using FluentAssertions;
using StatePattern.Models;
using Xunit;

namespace StatePattern.Tests.OrderTest
{
    public abstract class NonModifiableOrderTests
    {
        protected Order Order;

        protected NonModifiableOrderTests()
        {
            Order = new Order();
        }
        
        [Fact]
        public void AddItem_should_throw()
        {
            Action addItemAction = () => Order.AddItem(new OrderItem());

            addItemAction.Should().Throw<Exception>();
        }
    }
}