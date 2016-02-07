using NUnit.Framework;
using ProjectEuler.Helpers;
using System.Linq;

namespace ProjectEulerTests.ExtensionMethods
{
	public class IntegerExtensionMethodsTests
	{
		[TestCase(1, true)]
		[TestCase(43, true)]
		[TestCase(71, true)]
		[TestCase(1097, true)]
		[TestCase(100271, true)]
		[TestCase(2147483647, true), Explicit]
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

		[TestCase(12, 1, 2, 3, 4, 6, 12)]
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

		[TestCase(12, 1, 2, 3, 4, 6, 12)]
		[TestCase(100, 1, 2, 4, 5, 10, 20, 25, 50, 100)]
		[TestCase(220, 1, 2, 4, 5, 10, 11, 20, 22, 44, 55, 110, 220)]
		public void FindProperDivisors(int underTest, params int[] divisors)
		{
			//arrange
			//act
			var actual = underTest.FindDivisors().ToList();

			//assert
			Assert.That(actual, Has.Count.EqualTo(divisors.Count()));
			Assert.That(actual.TrueForAll(divisors.Contains));
		}
	}
}
