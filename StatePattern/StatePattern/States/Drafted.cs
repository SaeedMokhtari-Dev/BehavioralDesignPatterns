namespace StatePattern.States
{
    public class Drafted: OrderStates
    {
        public override bool CanModify()
        {
            return true;
        }

        public override Canceled Cancel()
        {
            return new Canceled();
        }

        public override Confirmed Confirm()
        {
            return new Confirmed();
        }
    }
}