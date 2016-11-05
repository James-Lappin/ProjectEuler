using System;

namespace ProjectEuler.Domain.Utilities
{
	public class FibonacciUtility
	{
		public static double FindNthFibonacciNumber(int nthNumber)
		{
			var oneOverSqrt5 = 1 / Math.Sqrt(5);
			var part1 = 1 + Math.Sqrt(5);
			var part2 = part1 / 2;
			var part3 = Math.Pow(part2, nthNumber + 1);
			return Math.Round(oneOverSqrt5 * part3);
		}
	}
}
