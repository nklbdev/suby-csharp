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

        private static TSubscription ToTrunk(TSubscription s)
        {
            while (s.IsDisposed)
                s = s.Previous;
            return s;
        }

        protected void ForCurrentTrunk(Action<TSubscription> action)
        {
            var s = _first;
            var l = Last;
            while (s != l)
            {
                s = s.Next;
                if (s == null)
                    break;
                action(s);
                s = ToTrunk(s);
                l = ToTrunk(l);
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