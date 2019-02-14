using System;
using NUnit.Framework;

namespace NETSharp7
{
    [TestFixture]
    //Кортеж
    public class Tuples
    {
        (int idInt, string firstName, string lastName) LookupName(int id)
        {
            var idInt = id + 100;
            const string firstName = "Kostya";
            const string lastName = "Biskub";
            return (idInt, firstName, lastName);
        }

        [Test]
        public void NewExampleTest()
        {
            var result = LookupName(1);
            Console.WriteLine($"idInt: {result.Item1}, firstName: {result.Item2}, lastName: {result.Item3}");
            Console.WriteLine($"idInt: {result.idInt}, firstName: {result.firstName}, lastName: {result.lastName}");
        }
    }
}
