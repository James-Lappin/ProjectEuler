using System.Collections.Generic;
using NUnit.Framework;
using ProjectEuler.Domain.Problems;
using ProjectEuler.Domain.Utilities;

namespace ProjectEuler.Tests.Problems
{
	public class Problem022Tests
	{
		private Problem022 _instance;

		[SetUp]
		public void SetUp()
		{
			_instance = new Problem022(new FakeFileUtility());
		}

		[Test]
		public void Solve_WithFakeFileUtility()
		{
			//arrange

			//act
			var actual = _instance.Solve();

			//assert
			Assert.That(actual, Is.EqualTo("393"));
		}

		[TestCase("COLIN", 53)]
		[TestCase("Colin", 53)]
		[TestCase("JAMES", 48)]
		[TestCase("SAM", 33)]
		[TestCase("DAVE", 32)]
		[TestCase("", 0)]
		public void GetNameWorth(string name, int worth)
		{
			//arrange
			//act
			var actual = _instance.GetNameWorth(name);

			//assert
			Assert.That(actual, Is.EqualTo(worth));
		}
	}

	internal class FakeFileUtility : IFileUtility
	{
		public IEnumerable<string> ReadCsvFile(string fileName)
		{
			return new List<string> { "SAM", "COLIN", "DAVE", "JAMES" };
		}
	}
}
