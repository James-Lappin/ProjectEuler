using NUnit.Framework;
using ProjectEuler.Problems;
using System.Linq;

namespace ProjectEulerTests.Problems
{
	public class Problem023Tests
	{
		private Problem023 _instance;

		[SetUp]
		public void SetUp()
		{
			_instance = new Problem023();
		}

		[Test]
		public void Solve_WhereNumbersUnder100_ShouldEqual2766()
		{
			//arrange
			_instance.MaxValue = 100;

			//act
			var actual = _instance.Solve();

			//Assert
			Assert.That(actual, Is.EqualTo("2766"));
		}

		[TestCase(12, true, 6, 6)]
		[TestCase(12, true, 2, 10)]
		[TestCase(100, true, 1, 2, 3, 4, 5, 6, 25, 75)]
		[TestCase(12, false, 12, 10)]
		[TestCase(16, false, 1, 2, 3, 4, 6)]
		[TestCase(12, false, 100, 43, 62, 15)]
		[TestCase(50, false, 100, 43, 62, 15)]
		public void CanBeSumOfTwoNumbers(int number, bool expected, params int[] list)
		{
			//arrange
			//act
			var actual = _instance.CanBeSumOfTwoNumbers(list.ToList(), number);

			//assert
			Assert.That(actual, Is.EqualTo(expected));
		}
	}
}
