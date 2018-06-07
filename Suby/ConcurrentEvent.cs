using System;

namespace Suby
{
    public class ConcurrentEvent: ConcurrentEventBase<Subscription>, IEvent
    {
        public ConcurrentEvent() : base(new Subscription(null, null, null)) {}
        
        public IDisposable Subscribe(Action handler) =>
            AddSubscription(new Subscription(null, this, handler));

        public void Raise() => ForAllActive(s => s.Notify());
    }

    public class ConcurrentEvent<T>: ConcurrentEventBase<Subscription<T>>, IEvent<T>
    {
        public ConcurrentEvent() : base(new Subscription<T>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T> handler) =>
            AddSubscription(new Subscription<T>(null, this, handler));
        
        public void Raise(T v) => ForAllActive(s => s.Notify(v));
    }
    
    public class ConcurrentEvent<T1, T2>: ConcurrentEventBase<Subscription<T1, T2>>, IEvent<T1, T2>
    {
        public ConcurrentEvent() : base(new Subscription<T1, T2>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2> handler) =>
            AddSubscription(new Subscription<T1, T2>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2) => ForAllActive(s => s.Notify(v1, v2));
    }
    
    public class ConcurrentEvent<T1, T2, T3>: ConcurrentEventBase<Subscription<T1, T2, T3>>, IEvent<T1, T2, T3>
    {
        public ConcurrentEvent() : base(new Subscription<T1, T2, T3>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3> handler) =>
            AddSubscription(new Subscription<T1, T2, T3>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3) => ForAllActive(s => s.Notify(v1, v2, v3));
    }
    
    public class ConcurrentEvent<T1, T2, T3, T4>: ConcurrentEventBase<Subscription<T1, T2, T3, T4>>, IEvent<T1, T2, T3, T4>
    {
        public ConcurrentEvent() : base(new Subscription<T1, T2, T3, T4>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3, T4> handler) =>
            AddSubscription(new Subscription<T1, T2, T3, T4>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3, T4 v4) => ForAllActive(s => s.Notify(v1, v2, v3, v4));
    }
    
    public class ConcurrentEvent<T1, T2, T3, T4, T5>: ConcurrentEventBase<Subscription<T1, T2, T3, T4, T5>>, IEvent<T1, T2, T3, T4, T5>
    {
        public ConcurrentEvent() : base(new Subscription<T1, T2, T3, T4, T5>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3, T4, T5> handler) =>
            AddSubscription(new Subscription<T1, T2, T3, T4, T5>(null, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5) => ForAllActive(s => s.Notify(v1, v2, v3, v4, v5));
    }
}
