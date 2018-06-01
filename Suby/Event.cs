using System;

namespace Suby
{
    public class Event: EventBase<Subscription>, IEvent
    {
        public Event() : base(new Subscription(null, null, null)) {}
        
        public IDisposable Subscribe(Action handler) =>
            AddSubscription(new Subscription(Last, this, handler));

        public void Raise()
        { foreach (var subscription in GetCurrentTrunk()) subscription.Notify(); }
    }
    
    public class Event<T>: EventBase<Subscription<T>>, IEvent<T>
    {
        public Event() : base(new Subscription<T>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T> handler) =>
            AddSubscription(new Subscription<T>(Last, this, handler));
        
        public void Raise(T v)
        { foreach (var subscription in GetCurrentTrunk()) subscription.Notify(v); }
    }
    
    public class Event<T1, T2>: EventBase<Subscription<T1, T2>>, IEvent<T1, T2>
    {
        public Event() : base(new Subscription<T1, T2>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2> handler) =>
            AddSubscription(new Subscription<T1, T2>(Last, this, handler));
        
        public void Raise(T1 v1, T2 v2)
        { foreach (var subscription in GetCurrentTrunk()) subscription.Notify(v1, v2); }
    }
    
    public class Event<T1, T2, T3>: EventBase<Subscription<T1, T2, T3>>, IEvent<T1, T2, T3>
    {
        public Event() : base(new Subscription<T1, T2, T3>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3> handler) =>
            AddSubscription(new Subscription<T1, T2, T3>(Last, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3)
        { foreach (var subscription in GetCurrentTrunk()) subscription.Notify(v1, v2, v3); }
    }
    
    public class Event<T1, T2, T3, T4>: EventBase<Subscription<T1, T2, T3, T4>>, IEvent<T1, T2, T3, T4>
    {
        public Event() : base(new Subscription<T1, T2, T3, T4>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3, T4> handler) =>
            AddSubscription(new Subscription<T1, T2, T3, T4>(Last, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3, T4 v4)
        { foreach (var subscription in GetCurrentTrunk()) subscription.Notify(v1, v2, v3, v4); }
    }
    
    public class Event<T1, T2, T3, T4, T5>: EventBase<Subscription<T1, T2, T3, T4, T5>>, IEvent<T1, T2, T3, T4, T5>
    {
        public Event() : base(new Subscription<T1, T2, T3, T4, T5>(null, null, null)) {}
        
        public IDisposable Subscribe(Action<T1, T2, T3, T4, T5> handler) =>
            AddSubscription(new Subscription<T1, T2, T3, T4, T5>(Last, this, handler));
        
        public void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5)
        { foreach (var subscription in GetCurrentTrunk()) subscription.Notify(v1, v2, v3, v4, v5); }
    }
}