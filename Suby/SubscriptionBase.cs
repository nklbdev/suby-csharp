using System;

namespace Suby
{
    public abstract class SubscriptionBase<TSubscription>: IDisposable where TSubscription: SubscriptionBase<TSubscription>
    {
        internal bool IsDisposed;
        internal TSubscription Previous;
        internal TSubscription Next;

        protected SubscriptionBase(TSubscription previous) => Previous = previous;

        public abstract void Dispose();
    }
}
