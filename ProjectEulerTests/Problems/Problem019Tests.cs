using NUnit.Framework;
using ProjectEuler.Problems;
using System;

namespace ProjectEulerTests
{
	public class Problem019Tests
	{
		private Problem019 _instance;

		[SetUp]
		public void SetUp()
		{
			_instance = new Problem019();
		}

		[Test]
		public void TheYear1900()
		{
			//arrange
			_instance.StartDate = new DateTime(1900, 1, 1);
			_instance.FinishDate = new DateTime(1900, 12, 31);

			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo(2.ToString()));
		}

		[Test]
		public void TheYear1901()
		{
			//arrange
			_instance.StartDate = new DateTime(1901, 1, 1);
			_instance.FinishDate = new DateTime(1901, 12, 31);

			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo(2.ToString()));
		}

		[Test]
		public void TheYear2000()
		{
			//arrange
			_instance.StartDate = new DateTime(2000, 1, 1);
			_instance.FinishDate = new DateTime(2000, 12, 31);

			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo(1.ToString()));
		}

		[Test]
		public void From1901To1910()
		{
			//arrange
			_instance.StartDate = new DateTime(1901, 1, 1);
			_instance.FinishDate = new DateTime(1910, 12, 31);

			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo(17.ToString()));
		}

		[Test]
		public void TwentiethCentry()
		{
			//arrange
			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo(171.ToString()));
		}
	}
}
