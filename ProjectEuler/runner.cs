using System;

public class runner
{

	public static void main(String[] args)
	{

		//needed for problem24
		//int[] digits = {0,1,2,3,4,5,6,7,8,9}; 

		//Start timer
		Console.WriteLine(Problem19.Solve());
		//stop stopwatch 
		//print out time
	}


	public static bool isPrime(long p)
	{
		for (long n = 2; n < p; n++)
		{
			if (p % n == 0)
			{
				return false;
			}
		}
		return true;
	}

	//Will only give accurate results to n less than 20
	public static long factorial(int n)
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
