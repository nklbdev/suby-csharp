using System;

namespace Suby
{
    public abstract class EventBase<TSubscription> where TSubscription: SubscriptionBase<TSubscription>
    {
        private readonly TSubscription _first;
        protected TSubscription Last;
        private readonly MyLock _writeLock = new MyLock();

        protected TSubscription AddSubscription(TSubscription s)
        {
            using (_writeLock.Expose())
            {
                s.Previous = Last;
                Last.Next = s;
                Last = s;
                return s;
            }
        }

        protected void ForAllActive(Action<TSubscription> action)
        {
            _writeLock.Expose();
            var current = _first;
            var last = Last;
            while (current != last && current.Next != null)
            {
                current = current.Next;
                _writeLock.Dispose();
                action(current);
                _writeLock.Expose();
                current = ToTrunk(current);
                last = ToTrunk(last);
            }
            _writeLock.Dispose();
        }

        private static TSubscription ToTrunk(TSubscription subscription)
        {
            while (subscription.IsDisposed)
                subscription = subscription.Previous;
            return subscription;
        }

        internal void DisposeSubscription(TSubscription s)
        {
            using (_writeLock.Expose())
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
        }

        protected EventBase(TSubscription dummy)
        {
            _first = dummy;
            Last = dummy;
        }
    }
}