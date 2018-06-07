using System;

namespace Suby
{
    public class Event: EventBase<Subscription>, IEvent
    {
        public Event() : base(new Subscription(null, null, null)) {}
        
        public IDisposable Subscribe(Action handler) =>
            AddSubscription(new Subscription(null, this, handler));

        public void Raise() => ForAllActive(s => s.Notify());
    }

    public class Event<T>: EventBase<Subscription<T>>, IEvent<T>
    {
        public Event() : base(new Subscription<T>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T> handler) =>
            AddSubscription(new Subscription<T>(null, this, handler));
        
        public void Raise(T v) => ForAllActive(s => s.Notify(v));
    }
    
    public class Event<T1, T2>: EventBase<Subscription<T1, T2>>, IEvent<T1, T2>
    {
        public Event() : base(new Subscription<T1, T2>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2> handler) =>
            AddSubscription(new Subscription<T1, T2>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2) => ForAllActive(s => s.Notify(v1, v2));
    }
    
    public class Event<T1, T2, T3>: EventBase<Subscription<T1, T2, T3>>, IEvent<T1, T2, T3>
    {
        public Event() : base(new Subscription<T1, T2, T3>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3> handler) =>
            AddSubscription(new Subscription<T1, T2, T3>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3) => ForAllActive(s => s.Notify(v1, v2, v3));
    }
    
    public class Event<T1, T2, T3, T4>: EventBase<Subscription<T1, T2, T3, T4>>, IEvent<T1, T2, T3, T4>
    {
        public Event() : base(new Subscription<T1, T2, T3, T4>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3, T4> handler) =>
            AddSubscription(new Subscription<T1, T2, T3, T4>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3, T4 v4) => ForAllActive(s => s.Notify(v1, v2, v3, v4));
    }
    
    public class Event<T1, T2, T3, T4, T5>: EventBase<Subscription<T1, T2, T3, T4, T5>>, IEvent<T1, T2, T3, T4, T5>
    {
        public Event() : base(new Subscription<T1, T2, T3, T4, T5>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3, T4, T5> handler) =>
            AddSubscription(new Subscription<T1, T2, T3, T4, T5>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5) => ForAllActive(s => s.Notify(v1, v2, v3, v4, v5));
    }
    
    public class Event<T1, T2, T3, T4, T5, T6>: EventBase<Subscription<T1, T2, T3, T4, T5, T6>>, IEvent<T1, T2, T3, T4, T5, T6>
    {
        public Event() : base(new Subscription<T1, T2, T3, T4, T5, T6>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6> handler) =>
            AddSubscription(new Subscription<T1, T2, T3, T4, T5, T6>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6) => ForAllActive(s => s.Notify(v1, v2, v3, v4, v5, v6));
    }
    
    public class Event<T1, T2, T3, T4, T5, T6, T7>: EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7>>, IEvent<T1, T2, T3, T4, T5, T6, T7>
    {
        public Event() : base(new Subscription<T1, T2, T3, T4, T5, T6, T7>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7> handler) =>
            AddSubscription(new Subscription<T1, T2, T3, T4, T5, T6, T7>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7) => ForAllActive(s => s.Notify(v1, v2, v3, v4, v5, v6, v7));
    }
    
    public class Event<T1, T2, T3, T4, T5, T6, T7, T8>: EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8>>, IEvent<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        public Event() : base(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8> handler) =>
            AddSubscription(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8) => ForAllActive(s => s.Notify(v1, v2, v3, v4, v5, v6, v7, v8));
    }
    
    public class Event<T1, T2, T3, T4, T5, T6, T7, T8, T9>: EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9>>, IEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        public Event() : base(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> handler) =>
            AddSubscription(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9) => ForAllActive(s => s.Notify(v1, v2, v3, v4, v5, v6, v7, v8, v9));
    }
    
    public class Event<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>: EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>>, IEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        public Event() : base(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> handler) =>
            AddSubscription(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10) => ForAllActive(s => s.Notify(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10));
    }
    
    public class Event<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>: EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>>, IEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        public Event() : base(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> handler) =>
            AddSubscription(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11) => ForAllActive(s => s.Notify(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11));
    }
    
    public class Event<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>: EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>>, IEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        public Event() : base(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> handler) =>
            AddSubscription(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12) => ForAllActive(s => s.Notify(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12));
    }
    
    public class Event<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>: EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>>, IEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        public Event() : base(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> handler) =>
            AddSubscription(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13) => ForAllActive(s => s.Notify(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13));
    }
    
    public class Event<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>: EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>>, IEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        public Event() : base(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> handler) =>
            AddSubscription(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13, T14 v14) => ForAllActive(s => s.Notify(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14));
    }
    
    public class Event<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>: EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>>, IEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        public Event() : base(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> handler) =>
            AddSubscription(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13, T14 v14, T15 v15) => ForAllActive(s => s.Notify(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15));
    }
    
    public class Event<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>: EventBase<Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>>, IEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    {
        public Event() : base(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> handler) =>
            AddSubscription(new Subscription<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13, T14 v14, T15 v15, T16 v16) => ForAllActive(s => s.Notify(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16));
    }
}