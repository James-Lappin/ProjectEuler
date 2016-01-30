using ProjectEuler.Helpers;
using System;

public class Problem24
{

	public string Solve(int[] digits, int n)
	{
		if (n > digits.Length.Factorial())
			throw new Exception("Requested number is too high");

		Array.Sort(digits);
		return getPermutation(digits, n);
	}

	private string getPermutation(int[] digits, int n)
	{

		string permutation = "";
		int currentPosition = 0;

		while (digits.Length != 0)
		{
			int j = 0;
			int max = (int)(digits.Length - 1).Factorial();
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

	private int[] removeIntFromArray(int[] digits, int j)
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