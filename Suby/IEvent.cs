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
    
    public interface IEvent<T1, T2, T3> : ISubscriptable<T1, T2, T3>
    {
        void Raise(T1 v1, T2 v2, T3 v3);
    }
    
    public interface IEvent<T1, T2, T3, T4> : ISubscriptable<T1, T2, T3, T4>
    {
        void Raise(T1 v1, T2 v2, T3 v3, T4 v4);
    }
    
    public interface IEvent<T1, T2, T3, T4, T5> : ISubscriptable<T1, T2, T3, T4, T5>
    {
        void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5);
    }
}