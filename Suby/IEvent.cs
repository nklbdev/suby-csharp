using System;

namespace Suby
{
    public interface IEvent
    {
        ISubscription Subscribe(Action handler);
    }
    
    public interface IEvent<out T>
    {
        ISubscription Subscribe(Action<T> handler);
    }
    
    public interface IEvent<out T1, out T2>
    {
        ISubscription Subscribe(Action<T1, T2> handler);
    }
}