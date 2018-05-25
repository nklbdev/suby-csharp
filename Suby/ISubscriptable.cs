using System;

namespace Suby
{
    public interface ISubscriptable
    {
        IDisposable Subscribe(Action handler);
    }
    
    public interface ISubscriptable<out T>
    {
        IDisposable Subscribe(Action<T> handler);
    }

    public interface ISubscriptable<out T1, out T2>
    {
        IDisposable Subscribe(Action<T1, T2> handler);
    }

    public interface ISubscriptable<out T1, out T2, out T3>
    {
        IDisposable Subscribe(Action<T1, T2, T3> handler);
    }
    
    public interface ISubscriptable<out T1, out T2, out T3, out T4>
    {
        IDisposable Subscribe(Action<T1, T2, T3, T4> handler);
    }
    
    public interface ISubscriptable<out T1, out T2, out T3, out T4, out T5>
    {
        IDisposable Subscribe(Action<T1, T2, T3, T4, T5> handler);
    }
}