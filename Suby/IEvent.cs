using System;

namespace Suby
{
    public interface ISubscriptable
    {
        IDisposable Subscribe(Action handler);
    }

    public interface IEvent : ISubscriptable
    {
        void Raise();
    }

    public interface ISubscriptable<out T>
    {
        IDisposable Subscribe(Action<T> handler);
    }
    
    public interface IEvent<T> : ISubscriptable<T>
    {
        void Raise(T v);
    }
    
    public interface ISubscriptable<out T1, out T2>
    {
        IDisposable Subscribe(Action<T1, T2> handler);
    }

    public interface IEvent<T1, T2> : ISubscriptable<T1, T2>
    {
        void Raise(T1 v1, T2 v2);
    }
}