using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Helpers
{
	public static class IntergerExtensionMethods
	{
		//maybe quicker to use Sieve of Eratosthenes and store?
		public static bool IsPrime(this int value)
		{
			for (long i = 2; i < value; i++)
			{
				if (value % i == 0)
				{
					return false;
				}
			}
			return true;
		}

		public static IEnumerable<int> FindDivisors(this int number)
		{
			var result = new HashSet<int>();
			var limit = Math.Sqrt(number);

			for (var i = 1; i <= limit; i++)
			{
				if (number % i != 0) continue;
				result.Add(i);
				result.Add(number / i);
			}

			return result;
		}

		public static IEnumerable<int> FindProperDivisors(this int number)
		{
			return number.FindDivisors().Where(x => x != number);
		}

		//Will only give accurate results to n less than 20
		public static long Factorial(this int n)
		{
			if (n > 20) throw new Exception("Value of n is to big for this function, will have to make it a BigInteger instead of long");

			long result = 1;
			for (int i = 1; i <= n; i++)
			{
				result *= i;
			}

			return result;
		}
	}
}
