using System;
using NUnit.Framework;

namespace NETSharp7
{
    [TestFixture]
    public class OutVariables
    {
        void DoSomething(out int x, out int y)
        {
            x = 1;
            y = 3;
        }


        [Test]
        public void OldExampleTest()
        {
            int x;
            int y;

            DoSomething(out x, out y);

            Console.WriteLine($"x: {x}, y: {y}");
        }

        [Test]
        public void NewExampleTest()
        {
            DoSomething(out var x, out var y);

            Console.WriteLine($"x: {x}, y: {y}");
        }
    }
}
