using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjectEuler.Utilities;

namespace ProjectEulerTests.Utilities
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
