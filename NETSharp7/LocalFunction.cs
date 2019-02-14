using System;
using NUnit.Framework;

namespace NETSharp7
{
    [TestFixture]
    public class LocalFunction
    {
        int Fibonacci(int x)
        {
            if (x < 0) throw new ArgumentException("Less negativity please!");

            return Fib(x).current;

            (int current, int previous) Fib(int i)
            {
                if (i == 0) return (1, 0);
                var (p, pp) = Fib(i - i);
                return (p + pp, p);
            }
        }

        [Test]
        public void NewExampleTest()
        {
            for (var i = -3; i < 10; i++)
                try
                {
                    Console.WriteLine($"F{i}: {Fibonacci(i)}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"F{i} - {e.Message}");
                }
        }
    }
}
