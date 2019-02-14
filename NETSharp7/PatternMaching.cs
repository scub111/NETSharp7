using System;
using NUnit.Framework;

namespace NETSharp7
{
    [TestFixture]
    public class PatternMaching
    {
        public void Print(object o)
        {
            switch (o)
            {
                case int i:
                    Console.WriteLine($"It is int with value: {i}");
                    break;
                case double d:
                    Console.WriteLine($"It is double with value: {d}");
                    break;
                case long l when l == 100:
                    Console.WriteLine($"It is long when value = {l} ");
                    break;
                default:
                    Console.WriteLine("It is default case");
                    break;
                case null:
                    Console.WriteLine("It is null");
                    break;
            }
        }

        [Test]
        public void NewExampleTest()
        {
            Print(10);
            Print((long)100);
            Print("test");
            Print(null);
        }
    }
}
