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
    
    public interface IEvent<T1, T2, T3, T4, T5, T6> : ISubscriptable<T1, T2, T3, T4, T5, T6>
    {
        void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6);
    }
    
    public interface IEvent<T1, T2, T3, T4, T5, T6, T7> : ISubscriptable<T1, T2, T3, T4, T5, T6, T7>
    {
        void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7);
    }
    
    public interface IEvent<T1, T2, T3, T4, T5, T6, T7, T8> : ISubscriptable<T1, T2, T3, T4, T5, T6, T7, T8>
    {
        void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8);
    }
    
    public interface IEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9> : ISubscriptable<T1, T2, T3, T4, T5, T6, T7, T8, T9>
    {
        void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9);
    }
    
    public interface IEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10> : ISubscriptable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>
    {
        void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10);
    }
    
    public interface IEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11> : ISubscriptable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>
    {
        void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11);
    }
    
    public interface IEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12> : ISubscriptable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>
    {
        void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12);
    }
    
    public interface IEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13> : ISubscriptable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>
    {
        void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13);
    }
    
    public interface IEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14> : ISubscriptable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>
    {
        void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13, T14 v14);
    }
    
    public interface IEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15> : ISubscriptable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>
    {
        void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13, T14 v14, T15 v15);
    }
    
    public interface IEvent<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16> : ISubscriptable<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>
    {
        void Raise(T1 v1, T2 v2, T3 v3, T4 v4, T5 v5, T6 v6, T7 v7, T8 v8, T9 v9, T10 v10, T11 v11, T12 v12, T13 v13, T14 v14, T15 v15, T16 v16);
    }
}