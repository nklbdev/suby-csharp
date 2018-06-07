using System;
using System.Diagnostics;
using Suby;

namespace ConcurrencyBenchmark
{
    internal static class Program
    {
        private static void Operation(IEvent e)
        {
            e.Raise();
            using (e.Subscribe(() => { }))
            {
                e.Raise();
            }
            e.Raise();
        }

        private static void Operation()
        {
        }

        private static void Bench(Action action)
        {
            const int iterationCount = 10000000;
            var sw = Stopwatch.StartNew();
            for (var iterationIndex = 0; iterationIndex < iterationCount; iterationIndex += 1)
                action();
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }

        [STAThread]
        private static void Main()
        {
            var e = new Event();
            Bench(() => Operation(e));
            var ce = new Event();
            Bench(() => Operation(ce));
            Bench(Operation);
        }
    }
}
