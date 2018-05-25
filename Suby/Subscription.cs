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
    
    public class Subscription<T1, T2, T3>: SubscriptionBase<Subscription<T1, T2, T3>>
    {
        private readonly Event<T1, T2, T3> _event;
        private readonly Action<T1, T2, T3> _handler;

        public Subscription(Subscription<T1, T2, T3> previous, Event<T1, T2, T3> e, Action<T1, T2, T3> handler)
            : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        protected override void NotifyDisposed() => _event.OnDisposed(this);

        public void Notify(T1 v1, T2 v2, T3 v3)
        {
            if (!IsDisposed)
                _handler(v1, v2, v3);
        }
    }
    
    public class Subscription<T1, T2, T3, T4>: SubscriptionBase<Subscription<T1, T2, T3, T4>>
    {
        private readonly Event<T1, T2, T3, T4> _event;
        private readonly Action<T1, T2, T3, T4> _handler;

        public Subscription(
            Subscription<T1, T2, T3, T4> previous,
            Event<T1, T2, T3, T4> e,
            Action<T1, T2, T3, T4> handler)
            : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        protected override void NotifyDisposed() => _event.OnDisposed(this);

        public void Notify(T1 v1, T2 v2, T3 v3, T4 v4)
        {
            if (!IsDisposed)
                _handler(v1, v2, v3, v4);
        }
    }
    
    public class Subscription<T1, T2, T3, T4, T5>: SubscriptionBase<Subscription<T1, T2, T3, T4, T5>>
    {
        private readonly Event<T1, T2, T3, T4, T5> _event;
        private readonly Action<T1, T2, T3, T4, T5> _handler;

        public Subscription(
            Subscription<T1, T2, T3, T4, T5> previous,
            Event<T1, T2, T3, T4, T5> e,
            Action<T1, T2, T3, T4, T5> handler)
            : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        protected override void NotifyDisposed() => _event.OnDisposed(this);

        public void Notify(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5)
        {
            if (!IsDisposed)
                _handler(v1, v2, v3, v4, v5);
        }
    }
}