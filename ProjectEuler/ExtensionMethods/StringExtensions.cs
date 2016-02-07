using System.Text.RegularExpressions;

namespace ProjectEuler.ExtensionMethods
{
	public static class StringExtensions
	{
		public static string RemoveNonAlphanumeric(this string value)
		{
			var regex = new Regex("[^a-zA-Z0-9]", RegexOptions.Compiled);
			return regex.Replace(value, "");
		}
	}
}
