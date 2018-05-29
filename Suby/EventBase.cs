using System;

namespace Suby
{
    public abstract class EventBase<TSubscription> where TSubscription: SubscriptionBase<TSubscription>
    {
        private readonly TSubscription _first;
        protected TSubscription Last;

        protected TSubscription AddSubscription(TSubscription s)
        {
            Last.Next = s;
            Last = s;
            return s;
        }

        private static TSubscription GetNextActive(TSubscription s)
        {
            while (s.IsDisposed)
                s = s.Previous;
            return s.Next;
        }

        protected void ForAllActive(Action<TSubscription> action)
        {
            var s = _first.Next;
            while (s != null)
            {
                action(s);
                s = GetNextActive(s);
            }
        }

        internal void OnDisposed(TSubscription s)
        {
            if (s == Last)
                Last = s.Previous;
        }

        protected EventBase(TSubscription dummy)
        {
            _first = dummy;
            Last = dummy;
        }
    }
}