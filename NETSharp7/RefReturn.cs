using System;
using NUnit.Framework;

namespace NETSharp7
{
    [TestFixture]
    public class RefReturn
    {
        public ref int Find(int number, int[] numbers)
        {
            for (var i = 0; i < numbers.Length; i++)
                if (numbers[i] == number)
                    return ref numbers[i];

            throw new IndexOutOfRangeException($"{nameof(number)} not found");
        }

        [Test]
        public void NewExampleTest()
        {
            int[] numbers = {1, 2, -5, 7, 38, 90};
            Console.WriteLine(string.Join(", ", numbers));

            ref int place = ref Find(7, numbers);
            place = 9;

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
