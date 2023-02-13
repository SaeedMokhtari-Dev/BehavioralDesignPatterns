using System;
using System.Collections.Generic;
using StatePattern.States;

namespace StatePattern.Models
{
    public class Order
    {
        private List<OrderItem> _items;
        public IReadOnlyCollection<OrderItem> Items => _items.AsReadOnly();
        public OrderStates State { get; private set; }

        public Order()
        {
            _items = new List<OrderItem>();
            State = new Drafted();
        } 
        public void AddItem(OrderItem item)
        {
            if (!State.CanModify())
                throw new Exception();
            _items.Add(item);
        }

        public void Cancel()
        {
            State = State.Cancel();
        }
        public void Confirm()
        {
            State = State.Confirm();
        }
    }
}