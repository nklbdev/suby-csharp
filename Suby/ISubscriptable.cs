using System;

namespace Suby
{
    public interface ISubscriptable<out T1, out T2>
    {
        IDisposable Subscribe(Action<T1, T2> handler);
    }

    public interface ISubscriptable<out T>
    {
        IDisposable Subscribe(Action<T> handler);
    }

    public interface ISubscriptable
    {
        IDisposable Subscribe(Action handler);
    }
}