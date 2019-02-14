using System;
using NUnit.Framework;

namespace NETSharp7
{
    [TestFixture]
    public class Deconstruction
    {
        (int idInt, string firstName, string lastName) LookupName(int id)
        {
            var idInt = id + 100;
            const string firstName = "Kostya";
            const string lastName = "Biskub";
            return (idInt, firstName, lastName);
        }

        [Test]
        public void NewExample1Test()
        {
            (var idInt, var firstName, var lastName) = LookupName(1);
            Console.WriteLine($"idInt: {idInt}, firstName: {firstName}, lastName: {lastName}");
        }

        [Test]
        public void NewExample2Test()
        {
            (var idInt, _, _) = LookupName(1);
            Console.WriteLine($"idInt: {idInt}");
        }
    }
}
