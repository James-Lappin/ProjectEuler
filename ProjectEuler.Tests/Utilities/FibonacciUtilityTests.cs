using NUnit.Framework;
using ProjectEuler.Domain.Utilities;

namespace ProjectEuler.Tests.Utilities
{
	public class FibonacciUtilityTests
	{
		[TestCase(0, 0)]
		[TestCase(1, 1)]
		[TestCase(2, 1)]
		[TestCase(3, 2)]
		[TestCase(10, 55)]
		[TestCase(20, 6765)]
		[TestCase(47, 2971215073)]
		[TestCase(50, 12586269025)]
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
