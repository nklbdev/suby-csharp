using System;

namespace Suby
{
    public abstract class SubscriptionBase<TSubscription>: IDisposable where TSubscription: SubscriptionBase<TSubscription>
    {
        protected bool IsDisposed;
        private TSubscription _previous;
        private TSubscription _next;

        public TSubscription Next
        {
            get { return IsDisposed ? Previous._next : _next; }
            set { _next = value == null ? null : value.IsDisposed ? value.Next : value; }
        }

        public TSubscription Previous
        {
            get { return IsDisposed ? _previous.Next : _previous; }
            set { _previous = value.IsDisposed ? value.Previous : value; }
        }

        protected SubscriptionBase(TSubscription previous)
        {
            _previous = previous;
        }

        public void Dispose()
        {
            if (IsDisposed)
                return;
            IsDisposed = true;

            _previous.Next = _next;
            if (_next != null)
                _next.Previous = _previous;
            _next = null;

            NotifyDisposed();
        }

        protected abstract void NotifyDisposed();
    }
}
