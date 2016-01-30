using System;

public class Problem24
{

	public static string Solve(int[] digits, int n)
	{
		if (n > runner.factorial(digits.Length))
			throw new Exception("Requested number is too high");

		Array.Sort(digits);
		return getPermutation(digits, n);
	}

	private static string getPermutation(int[] digits, int n)
	{

		string permutation = "";
		int currentPosition = 0;

		while (digits.Length != 0)
		{
			int j = 0;
			int max = (int)runner.factorial(digits.Length - 1);
			while (currentPosition + max < n)
			{
				currentPosition += max;
				j++;
			}

			permutation += digits[j].ToString();
			digits = removeIntFromArray(digits, j);
		}

		return permutation;
	}

	private static int[] removeIntFromArray(int[] digits, int j)
	{
		int[] result = new int[digits.Length - 1];
		int k = 0;

		for (int i = 0; i < digits.Length; i++)
		{

			if (i == j) continue;

			result[k] = digits[i];
			k++;
		}

		return result;
	}
}