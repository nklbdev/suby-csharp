using System;

namespace Suby
{
    public class Subscription: SubscriptionBase<Subscription>
    {
        private readonly EventBase<Subscription> _event;
        private readonly Action _handler;

        public Subscription(Subscription previous, EventBase<Subscription> e, Action handler) : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        public override void Dispose() => _event.DisposeSubscription(this);

        public void Notify() => _handler();
    }
    
    public class Subscription<T>: SubscriptionBase<Subscription<T>>
    {
        private readonly EventBase<Subscription<T>> _event;
        private readonly Action<T> _handler;

        public Subscription(Subscription<T> previous, EventBase<Subscription<T>> e, Action<T> handler) : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        public override void Dispose() => _event.DisposeSubscription(this);

        public void Notify(T v) => _handler(v);
    }
    
    public class Subscription<T1, T2>: SubscriptionBase<Subscription<T1, T2>>
    {
        private readonly EventBase<Subscription<T1, T2>> _event;
        private readonly Action<T1, T2> _handler;

        public Subscription(Subscription<T1, T2> previous, EventBase<Subscription<T1, T2>> e, Action<T1, T2> handler) : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        public override void Dispose() => _event.DisposeSubscription(this);

        public void Notify(T1 v1, T2 v2) => _handler(v1, v2);
    }
    
    public class Subscription<T1, T2, T3>: SubscriptionBase<Subscription<T1, T2, T3>>
    {
        private readonly EventBase<Subscription<T1, T2, T3>> _event;
        private readonly Action<T1, T2, T3> _handler;

        public Subscription(Subscription<T1, T2, T3> previous, EventBase<Subscription<T1, T2, T3>> e, Action<T1, T2, T3> handler)
            : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        public override void Dispose() => _event.DisposeSubscription(this);

        public void Notify(T1 v1, T2 v2, T3 v3) => _handler(v1, v2, v3);
    }
    
    public class Subscription<T1, T2, T3, T4>: SubscriptionBase<Subscription<T1, T2, T3, T4>>
    {
        private readonly EventBase<Subscription<T1, T2, T3, T4>> _event;
        private readonly Action<T1, T2, T3, T4> _handler;

        public Subscription(
            Subscription<T1, T2, T3, T4> previous,
            EventBase<Subscription<T1, T2, T3, T4>> e,
            Action<T1, T2, T3, T4> handler)
            : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        public override void Dispose() => _event.DisposeSubscription(this);

        public void Notify(T1 v1, T2 v2, T3 v3, T4 v4) => _handler(v1, v2, v3, v4);
    }
    
    public class Subscription<T1, T2, T3, T4, T5>: SubscriptionBase<Subscription<T1, T2, T3, T4, T5>>
    {
        private readonly EventBase<Subscription<T1, T2, T3, T4, T5>> _event;
        private readonly Action<T1, T2, T3, T4, T5> _handler;

        public Subscription(
            Subscription<T1, T2, T3, T4, T5> previous,
            EventBase<Subscription<T1, T2, T3, T4, T5>> e,
            Action<T1, T2, T3, T4, T5> handler)
            : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        public override void Dispose() => _event.DisposeSubscription(this);

        public void Notify(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5) => _handler(v1, v2, v3, v4, v5);
    }
}