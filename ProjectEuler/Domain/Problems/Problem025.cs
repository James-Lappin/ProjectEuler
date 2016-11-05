using ProjectEuler.Interfaces;
using System;
using System.Numerics;

namespace ProjectEuler.Problems
{
	public class Problem025 : IProblem
	{
		public int AmountOfDigits { get; set; } = 1000;

		//brute force
		public string Solve()
		{
			var nthNumber = new BigInteger(1);
			var nthPlusOneNumber = new BigInteger(1);
			var answer = new BigInteger(2);
			
			long result = 2;

			while (answer.ToString().Length < AmountOfDigits)
			{
				answer = nthNumber + nthPlusOneNumber;

				nthNumber = nthPlusOneNumber;
				nthPlusOneNumber = answer;

				result++;
			}

			return result.ToString();
		}
	}
}