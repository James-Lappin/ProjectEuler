using NUnit.Framework;
using ProjectEuler.Domain.Utilities;

namespace ProjectEuler.Tests.Utilities
{
	public class FibonacciUtilityTests
	{
		[TestCase(0, 1)]
		[TestCase(1, 1)]
		[TestCase(2, 2)]
		[TestCase(10, 89)]
		[TestCase(20, 10946)]
		[TestCase(47, 20365011074)]
		[TestCase(50, 20365011074)]
		public void FindNthFibonacciNumber(int nthNumber, long expected)
		{
			//arrange
			//act
			var actual = FibonacciUtility.FindNthFibonacciNumber(nthNumber);
			//assert
			Assert.That(actual, Is.EqualTo(expected));
		}
	}
}
