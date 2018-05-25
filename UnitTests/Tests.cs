using System;
using System.Collections.Generic;
using NUnit.Framework;
using Suby;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        private static void Handler()
        {
            throw new NotImplementedException();
        }
        
        private static void Handler5(int a, string b, bool c, char d, object e)
        {
            throw new NotImplementedException();
        }
        
        [Test]
        public void Test1()
        {
            var e = new Event();
            ISubscriptable subscriptable = e;
            using (subscriptable.Subscribe(Handler))
                Assert.Throws<NotImplementedException>(() => e.Raise());
        }
        
        [Test]
        public void Test5()
        {
            var e = new Event<int, string, bool, char, object>();
            ISubscriptable<int, string, bool, char, object> subscriptable = e;
            using (subscriptable.Subscribe(Handler5))
                Assert.Throws<NotImplementedException>(() => e.Raise(3, "asd", false, 'e', new object()));
        }
        
        [Test]
        public void Test2()
        {
            var e = new Event();
            ISubscriptable subscriptable = e;
            using (subscriptable.Subscribe(Handler)) { }
            e.Raise();
        }
        
        private static void Handler(string some)
        {
            throw new NotImplementedException();
        }
        
        [Test]
        public void TestT1()
        {
            var e = new Event<string>();
            ISubscriptable<string> subscriptable = e;
            using (subscriptable.Subscribe(Handler))
                Assert.Throws<NotImplementedException>(() => e.Raise("some"));
        }
        
        [Test]
        public void TestT2()
        {
            var e = new Event<string>();
            ISubscriptable<string> subscriptable = e;
            using (subscriptable.Subscribe(Handler)) { }
            e.Raise("some");
        }
        
        private static void Handler(string some, int sadf)
        {
            throw new NotImplementedException();
        }
        
        [Test]
        public void TestTT1()
        {
            var e = new Event<string, int>();
            ISubscriptable<string, int> subscriptable = e;
            using (subscriptable.Subscribe(Handler))
                Assert.Throws<NotImplementedException>(() => e.Raise("some", 42));
        }
        
        [Test]
        public void TestTT2()
        {
            var e = new Event<string, int>();
            ISubscriptable<string, int> subscriptable = e;
            using (subscriptable.Subscribe(Handler)) { }
            e.Raise("some", 42);
        }

        [Test]
        public void NewHandlerWillBeInvoked_IfItIsSubscribedInNotifyingProgress()
        {
            var e = new Event();
            var secondHandlerIsInvoked = false;
            e.Subscribe(() =>
                e.Subscribe(() =>
                    secondHandlerIsInvoked = true));
            e.Raise();
            Assert.IsTrue(secondHandlerIsInvoked);
        }
    }
}