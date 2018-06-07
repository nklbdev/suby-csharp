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
    
    public interface ISubscriptable<out T1, out T2, out T3, out T4, out T5, out T6>
    {
        IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6> handler);
    }
    
    public interface ISubscriptable<out T1, out T2, out T3, out T4, out T5, out T6, out T7>
    {
        IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7> handler);
    }
    
    public interface ISubscriptable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8>
    {
        IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8> handler);
    }
    
    public interface ISubscriptable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9>
    {
        IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9> handler);
    }
    
    public interface ISubscriptable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10>
    {
        IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> handler);
    }
    
    public interface ISubscriptable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11>
    {
        IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> handler);
    }
    
    public interface ISubscriptable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12>
    {
        IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> handler);
    }
    
    public interface ISubscriptable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13>
    {
        IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> handler);
    }
    
    public interface ISubscriptable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14>
    {
        IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> handler);
    }
    
    public interface ISubscriptable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15>
    {
        IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> handler);
    }
    
    public interface ISubscriptable<out T1, out T2, out T3, out T4, out T5, out T6, out T7, out T8, out T9, out T10, out T11, out T12, out T13, out T14, out T15, out T16>
    {
        IDisposable Subscribe(Action<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> handler);
    }
}