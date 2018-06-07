using System;

namespace Suby
{
    public abstract class ConcurrentEventBase<TSubscription> : EventBase<TSubscription> where TSubscription: SubscriptionBase<TSubscription>
    {
        private readonly object _lockObject = new object();

        protected ConcurrentEventBase(TSubscription dummy) : base(dummy) { }

        protected override TSubscription AddSubscription(TSubscription s)
        {
            lock (_lockObject)
                return base.AddSubscription(s);
        }

        protected override void ForAllActive(Action<TSubscription> action)
        {
            lock (_lockObject)
                base.ForAllActive(action);
        }

        internal override void DisposeSubscription(TSubscription s)
        {
            lock (_lockObject)
                base.DisposeSubscription(s);
        }
    }
}