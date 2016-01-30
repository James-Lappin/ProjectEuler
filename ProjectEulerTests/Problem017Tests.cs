using NUnit.Framework;
using ProjectEuler.Problems;

namespace ProjectEulerTests
{
	public class Problem017Tests
	{
		private Problem017 _instance;

		[SetUp]
		public void SetUp()
		{
			_instance = new Problem017();
		}

		[Test]
		public void OneToFive()
		{
			//arrange
			_instance.StartingNumber = 1;
			_instance.FinishingNumber = 5;

			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo(19.ToString()));
		}

		[Test]
		public void NineteenToTwentyOne()
		{
			//arrange
			_instance.StartingNumber = 19;
			_instance.FinishingNumber = 21;

			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo(23.ToString()));
		}

		[Test]
		public void EightySix()
		{
			//arrange
			_instance.StartingNumber = 86;
			_instance.FinishingNumber = 86;

			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo(9.ToString()));
		}

		//10 + 10 + 16
		[Test]
		public void NinetyNineToOneHundredAndOne()
		{
			//arrange
			_instance.StartingNumber = 99;
			_instance.FinishingNumber = 101;

			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo(36.ToString()));
		}

		[Test]
		public void OneHundredAndFifteen()
		{
			//arrange
			_instance.StartingNumber = 115;
			_instance.FinishingNumber = 115;

			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo(20.ToString()));
		}

		[Test]
		public void ThreeHundredAndFortyTwo()
		{
			//arrange
			_instance.StartingNumber = 342;
			_instance.FinishingNumber = 342;

			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo(23.ToString()));
		}

		[Test]
		public void OneThousand()
		{
			//arrange
			_instance.StartingNumber = 1000;
			_instance.FinishingNumber = 1000;
			//324990
			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo(11.ToString()));
		}

		[Test]
		public void OneToOneThousand()
		{
			//arrange
			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo(21124.ToString()));
		}
	}
}
