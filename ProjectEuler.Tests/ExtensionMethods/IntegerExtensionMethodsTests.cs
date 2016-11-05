using System.Linq;
using NUnit.Framework;
using ProjectEuler.Domain.ExtensionMethods;

namespace ProjectEuler.Tests.ExtensionMethods
{
    public class IntegerExtensionMethodsTests
    {
        [Test, Explicit]
        public void IsPrime_WhereLongRunning()
        {
            //arrange
            //act
            var actual = 2147483647.IsPrime();

            //assert
            Assert.That(actual);
        }

        [TestCase(1, true)]
        [TestCase(43, true)]
        [TestCase(71, true)]
        [TestCase(1097, true)]
        [TestCase(100271, true)]
        [TestCase(10, false)]
        [TestCase(57, false)]
        [TestCase(177, false)]
        [TestCase(1939, false)]
        [TestCase(181271, false)]
        public void IsPrime(int underTest, bool expected)
        {
            //arrange
            //act
            var actual = underTest.IsPrime();

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(1, 1)]
        [TestCase(12, 1, 2, 3, 4, 6, 12)]
        [TestCase(25, 1, 5, 25)]
        [TestCase(100, 1, 2, 4, 5, 10, 20, 25, 50, 100)]
        [TestCase(220, 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, 110, 220)]
        public void FindDivisors(int underTest, params int[] divisors)
        {
            //arrange
            //act
            var actual = underTest.FindDivisors().ToList();

            //assert
            Assert.That(actual, Has.Count.EqualTo(divisors.Count()));
            Assert.That(actual.TrueForAll(divisors.Contains));
        }

        [TestCase(1)]
        [TestCase(12, 1, 2, 3, 4, 6)]
        [TestCase(25, 1, 5)]
        [TestCase(100, 1, 2, 4, 5, 10, 20, 25, 50)]
        [TestCase(220, 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, 110)]
        public void FindProperDivisors(int underTest, params int[] divisors)
        {
            //arrange
            //act
            var actual = underTest.FindProperDivisors().ToList();

            //assert
            Assert.That(actual, Has.Count.EqualTo(divisors.Count()));
            Assert.That(actual.TrueForAll(divisors.Contains));
        }

        [TestCase(16, false)]
        [TestCase(12, true)]
        [TestCase(1, false)]
        public void IsAbundantNumber(int number, bool expected)
        {
            //arrange
            //act
            var actual = number.IsAbundantNumber();

            //assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
