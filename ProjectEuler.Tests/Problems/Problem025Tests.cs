using NUnit.Framework;
using ProjectEuler.Domain.Problems;

namespace ProjectEuler.Tests.Problems
{
	public class Problem025Tests
	{
		private Problem025 _instance;

		[SetUp]
		public void Setup()
		{
			_instance = new Problem025();
		}

		[TestCase(2, 7)]
		[TestCase(3, 12)]
		[TestCase(4, 17)]
		[TestCase(1000, 4782)]
		public void Solve(int amountOfDigits, int expected)
		{
			//arrange
			_instance.AmountOfDigits = amountOfDigits;

			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo(expected.ToString()));
		}
	}
}
