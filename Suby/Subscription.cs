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
    
    public class Subscription<T1, T2, T3, T4, T5, T6>: SubscriptionBase<Subscription<T1, T2, T3, T4, T5, T6>>
    {
        private readonly EventBase<Subscription<T1, T2, T3, T4, T5, T6>> _event;
        private readonly Action<T1, T2, T3, T4, T5, T6> _handler;

        public Subscription(
            Subscription<T1, T2, T3, T4, T5, T6> previous,
            EventBase<Subscription<T1, T2, T3, T4, T5, T6>> e,
            Action<T1, T2, T3, T4, T5, T6> handler)
            : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        public override void Dispose() => _event.DisposeSubscription(this);

        public void Notify(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6) => _handler(v1, v2, v3, v4, v5, v6);
    }
    
    public class Subscription<T1, T2, T3, T4, T5, T6, T7>: SubscriptionBase<Subscription<T1, T2, T3, T4, T5, T6, T7>>
    {
        private readonly EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7>> _event;
        private readonly Action<T1, T2, T3, T4, T5, T6, T7> _handler;

        public Subscription(
            Subscription<T1, T2, T3, T4, T5, T6, T7> previous,
            EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7>> e,
            Action<T1, T2, T3, T4, T5, T6, T7> handler)
            : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        public override void Dispose() => _event.DisposeSubscription(this);

        public void Notify(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7) => _handler(v1, v2, v3, v4, v5, v6, v7);
    }
    
    public class Subscription<T1, T2, T3, T4, T5, T6, T7, T8>: SubscriptionBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8>>
    {
        private readonly EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8>> _event;
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8> _handler;

        public Subscription(
            Subscription<T1, T2, T3, T4, T5, T6, T7, T8> previous,
            EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8>> e,
            Action<T1, T2, T3, T4, T5, T6, T7, T8> handler)
            : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        public override void Dispose() => _event.DisposeSubscription(this);

        public void Notify(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8) => _handler(v1, v2, v3, v4, v5, v6, v7, v8);
    }
    
    public class Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9>: SubscriptionBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9>>
    {
        private readonly EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9>> _event;
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> _handler;

        public Subscription(
            Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9> previous,
            EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9>> e,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> handler)
            : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        public override void Dispose() => _event.DisposeSubscription(this);

        public void Notify(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9) => _handler(v1, v2, v3, v4, v5, v6, v7, v8, v9);
    }
    
    public class Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>: SubscriptionBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>
    {
        private readonly EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> _event;
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> _handler;

        public Subscription(
            Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> previous,
            EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>> e,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> handler)
            : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        public override void Dispose() => _event.DisposeSubscription(this);

        public void Notify(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10) => _handler(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10);
    }
    
    public class Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>: SubscriptionBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>
    {
        private readonly EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> _event;
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> _handler;

        public Subscription(
            Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> previous,
            EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>> e,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> handler)
            : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        public override void Dispose() => _event.DisposeSubscription(this);

        public void Notify(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11) => _handler(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11);
    }
    
    public class Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>: SubscriptionBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>
    {
        private readonly EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> _event;
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> _handler;

        public Subscription(
            Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> previous,
            EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>> e,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> handler)
            : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        public override void Dispose() => _event.DisposeSubscription(this);

        public void Notify(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12) => _handler(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12);
    }
    
    public class Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>: SubscriptionBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>
    {
        private readonly EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> _event;
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> _handler;

        public Subscription(
            Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> previous,
            EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>> e,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> handler)
            : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        public override void Dispose() => _event.DisposeSubscription(this);

        public void Notify(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13) => _handler(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13);
    }
    
    public class Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>: SubscriptionBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>
    {
        private readonly EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> _event;
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> _handler;

        public Subscription(
            Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> previous,
            EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>> e,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> handler)
            : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        public override void Dispose() => _event.DisposeSubscription(this);

        public void Notify(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13, T14 v14) => _handler(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14);
    }
    
    public class Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>: SubscriptionBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>
    {
        private readonly EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> _event;
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> _handler;

        public Subscription(
            Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> previous,
            EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>> e,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> handler)
            : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        public override void Dispose() => _event.DisposeSubscription(this);

        public void Notify(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13, T14 v14, T15 v15) => _handler(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15);
    }
    
    public class Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>: SubscriptionBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>
    {
        private readonly EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> _event;
        private readonly Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> _handler;

        public Subscription(
            Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> previous,
            EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>> e,
            Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> handler)
            : base(previous)
        {
            _event = e;
            _handler = handler;
        }

        public override void Dispose() => _event.DisposeSubscription(this);

        public void Notify(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13, T14 v14, T15 v15, T16 v16) => _handler(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16);
    }
}