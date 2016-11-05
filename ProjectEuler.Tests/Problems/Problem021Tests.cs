using NUnit.Framework;
using ProjectEuler.Domain.Problems;

namespace ProjectEuler.Tests.Problems
{
	[TestFixture]
	public class Problem021Tests
	{
		private Problem021 _instance;

		[SetUp]
		public void SetUp()
		{
			_instance = new Problem021();
		}

		[Test]
		public void Under300()
		{
			//arrange
			_instance.StartValue = 1;
			_instance.MaxValue = 300;

			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo(504.ToString()));
		}

		[Test]
		public void Under2000()
		{
			//arrange
			_instance.StartValue = 1;
			_instance.MaxValue = 2000;

			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo(2898.ToString()));
		}

		[Test]
		public void Under10000()
		{
			//arrange
			_instance.StartValue = 1;
			_instance.MaxValue = 10000;

			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo(31626.ToString()));
		}
	}
}
