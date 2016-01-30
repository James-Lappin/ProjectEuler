using System;

namespace ProjectEuler.Helpers
{
	public static class IntergerExtensionMethods
	{
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
