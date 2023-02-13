using System;

namespace StatePattern.States
{
    public abstract class OrderStates
    {
        public virtual bool CanModify()
        {
            return false;
        }
        public virtual Canceled Cancel()
        {
            throw new NotSupportedException();
        }
        public virtual Confirmed Confirm()
        {
            throw new NotSupportedException();
        }
    }
}