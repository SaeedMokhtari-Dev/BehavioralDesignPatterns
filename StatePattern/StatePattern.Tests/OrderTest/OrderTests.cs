using System;
using FluentAssertions;
using StatePattern.Models;
using StatePattern.States;
using Xunit;

namespace StatePattern.Tests.OrderTest
{
    public class OrderTests
    {
        private readonly Order _order;
        public OrderTests()
        {
            _order = new Order();
        }

        [Fact]
        public void Constructor_should_construct_order_in_draft_state()
        {
            _order.State.Should().BeOfType<Drafted>();
        }
        [Fact]
        public void Constructor_should_initialize_an_empty_list_as_items()
        {
            _order.Items.Should().BeEmpty();
        }
    }
}