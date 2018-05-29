using System;

namespace Suby
{
    public abstract class SubscriptionBase<TSubscription>: IDisposable where TSubscription: SubscriptionBase<TSubscription>
    {
        internal bool IsDisposed;
        public TSubscription Next;
        public TSubscription Previous;

        protected SubscriptionBase(TSubscription previous)
        {
            Previous = previous;
        }

        public void Dispose()
        {
            if (IsDisposed)
                return;
            IsDisposed = true;

            Previous.Next = Next;
            if (Next != null)
                Next.Previous = Previous;
            Next = null;

            NotifyDisposed();
        }

        protected abstract void NotifyDisposed();
    }
}