using System;

namespace Suby
{
    public abstract class EventBase<TSubscription> where TSubscription: SubscriptionBase<TSubscription>
    {
        private readonly TSubscription _first;
        protected TSubscription Last;

        protected virtual TSubscription AddSubscription(TSubscription s)
        {
            s.Previous = Last;
            Last.Next = s;
            Last = s;
            return s;
        }

        protected virtual void ForAllActive(Action<TSubscription> action)
        {
            var current = _first;
            var last = Last;
            while (current != last && current.Next != null)
            {
                current = current.Next;
                action(current);
                current = ToTrunk(current);
                last = ToTrunk(last);
            }
        }

        private static TSubscription ToTrunk(TSubscription subscription)
        {
            while (subscription.IsDisposed)
                subscription = subscription.Previous;
            return subscription;
        }

        internal virtual void DisposeSubscription(TSubscription s)
        {
            if (s.IsDisposed)
                return;
            if (s.Next != null)
                s.Next.Previous = s.Previous;
            s.Previous.Next = s.Next;
            s.Next = null;
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