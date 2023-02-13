using System;
using FluentAssertions;
using StatePattern.Models;
using StatePattern.States;
using Xunit;

namespace StatePattern.Tests.OrderTest
{
    public class OrderTestsWhenDrafted
    {
        private readonly Order _order;
        public OrderTestsWhenDrafted()
        {
            _order = new Order();
        }
        [Fact]
        public void Cancel_should_change_to_canceled()
        {
            _order.Cancel();

            _order.State.Should().BeOfType<Canceled>();
        }
        [Fact]
        public void Confirm_should_change_to_confirmed()
        {
            _order.Confirm();

            _order.State.Should().BeOfType<Confirmed>();
        }
        
        [Fact]
        public void AddItem_should_add_order_item()
        {
            var item = new OrderItem();
            _order.AddItem(item);

            _order.Items.Should().HaveCount(1).And.Contain(item);
        }
    }
}