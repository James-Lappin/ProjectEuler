using NUnit.Framework;
using ProjectEuler.Domain.ExtensionMethods;

namespace ProjectEuler.Tests.ExtensionMethods
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
