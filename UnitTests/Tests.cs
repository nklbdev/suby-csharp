using System;
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
        
        [Test]
        public void Test1()
        {
            var e = new Event();
            ISubscriptable subscriptable = e;
            using (subscriptable.Subscribe(Handler))
                Assert.Throws<NotImplementedException>(() => e.Raise());
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
    }
}