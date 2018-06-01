using System.Collections.Generic;

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

        protected IEnumerable<TSubscription> GetCurrentTrunk()
        {
            var s = _first.Next;
            while (s != null)
            {
                yield return s;
                s = s.Next;
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