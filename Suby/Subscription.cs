using System;

namespace Suby
{
    public abstract class SubscriptionBase<TSubscription>: IDisposable where TSubscription: SubscriptionBase<TSubscription>
    {
        internal bool IsDisposed;
        public TSubscription Next;
        public TSubscription Previous;

        protected SubscriptionBase(TSubscription previous)
        {
            Previous = previous;
        }

        public void Dispose()
        {
            if (IsDisposed)
                return;
            IsDisposed = true;

            Previous.Next = Next;
            if (Next != null)
                Next.Previous = Previous;
            Next = null;

            NotifyDisposed();
        }

        protected abstract void NotifyDisposed();
    }

    public class Subscription: SubscriptionBase<Subscription>
    {
        private readonly Event _event;
        private readonly Action _handler;

        public Subscription(Subscription previous, Event e, Action handler) : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        protected override void NotifyDisposed() => _event.OnDisposed(this);

        public void Notify()
        {
            if (!IsDisposed)
                _handler();
        }
    }
    
    public class Subscription<T>: SubscriptionBase<Subscription<T>>
    {
        private readonly Event<T> _event;
        private readonly Action<T> _handler;

        public Subscription(Subscription<T> previous, Event<T> e, Action<T> handler) : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        protected override void NotifyDisposed() => _event.OnDisposed(this);

        public void Notify(T v)
        {
            if (!IsDisposed)
                _handler(v);
        }
    }
    
    public class Subscription<T1, T2>: SubscriptionBase<Subscription<T1, T2>>
    {
        private readonly Event<T1, T2> _event;
        private readonly Action<T1, T2> _handler;

        public Subscription(Subscription<T1, T2> previous, Event<T1, T2> e, Action<T1, T2> handler) : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        protected override void NotifyDisposed() => _event.OnDisposed(this);

        public void Notify(T1 v1, T2 v2)
        {
            if (!IsDisposed)
                _handler(v1, v2);
        }
    }
}