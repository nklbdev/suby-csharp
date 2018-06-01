using System;
using System.Threading;

namespace Suby
{
    internal class MyLock : IDisposable
    {
        private SpinLock _spinLock = new SpinLock();

        public MyLock Expose()
        {
            var lockTaken = false;
            _spinLock.Enter(ref lockTaken);
            return this;
        }

        public void Dispose()
        {
            _spinLock.Exit(false);
        }
    }
}