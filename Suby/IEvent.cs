namespace Suby
{
    public interface IEvent : ISubscriptable
    {
        void Raise();
    }

    public interface IEvent<T> : ISubscriptable<T>
    {
        void Raise(T v);
    }

    public interface IEvent<T1, T2> : ISubscriptable<T1, T2>
    {
        void Raise(T1 v1, T2 v2);
    }
}