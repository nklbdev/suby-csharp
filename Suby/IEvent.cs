using System;

namespace Suby
{
    public interface IEvent
    {
        IDisposable Subscribe(Action handler);
    }
    
    public interface IEvent<out T>
    {
        IDisposable Subscribe(Action<T> handler);
    }
    
    public interface IEvent<out T1, out T2>
    {
        IDisposable Subscribe(Action<T1, T2> handler);
    }
}