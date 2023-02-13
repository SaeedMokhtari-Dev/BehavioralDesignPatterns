using System;
using FluentAssertions;
using StatePattern.Models;
using Xunit;

namespace StatePattern.Tests.OrderTest
{
    public class OrderTestsWhenCanceled: NonModifiableOrderTests
    {
        public OrderTestsWhenCanceled()
        {   
            Order.Cancel();
        }
        
        [Fact]
        public void Cancel_should_throw()
        {
            Action cancelAction = () => Order.Cancel();

            cancelAction.Should().Throw<NotSupportedException>();
        }
        [Fact]
        public void Confirm_should_throw()
        {
            Action confirmAction = () => Order.Confirm();

            confirmAction.Should().Throw<NotSupportedException>();
        }
    }
}