using NUnit.Framework;
using ProjectEuler.ExtensionMethods;
using ProjectEuler.Utilities;

namespace ProjectEulerTests.ExtensionMethods
{
	public class StringExtensionMethodsTests
	{
		[TestCase("\"Dave", "Dave")]
		[TestCase("!@£$%^&*()_+=-{}][:';\\|?/><.,§±~`", "")]
		[TestCase("\"DaVe\"", "DaVe")]
		[TestCase("WorD", "WorD")]
		public void Remove(string input, string expected)
		{
			//act
			var actual = input.RemoveNonAlphanumeric();

			//assert
			Assert.That(actual, Is.EqualTo(expected));
		}
	}
}
