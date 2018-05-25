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
            if (!s.IsDisposed)
                return s.Next;
            var p = s.Previous;
            while (p.IsDisposed)
                p = p.Previous;
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
    
    public class Event: EventBase<Subscription>, IEvent
    {
        public Event() : base(new Subscription(null, null, null)) {}
        
        public IDisposable Subscribe(Action handler) =>
            AddSubscription(new Subscription(Last, this, handler));

        public void Raise() => ForAllActive(s => s.Notify());
    }
    
    public class Event<T>: EventBase<Subscription<T>>, IEvent<T>
    {
        public Event() : base(new Subscription<T>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T> handler) =>
            AddSubscription(new Subscription<T>(Last, this, handler));
        
        public void Raise(T v) => ForAllActive(s => s.Notify(v));
    }
    
    public class Event<T1, T2>: EventBase<Subscription<T1, T2>>, IEvent<T1, T2>
    {
        public Event() : base(new Subscription<T1, T2>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2> handler) =>
            AddSubscription(new Subscription<T1, T2>(Last, this, handler));
        
        public void Raise(T1 v1, T2 v2) => ForAllActive(s => s.Notify(v1, v2));
    }
}