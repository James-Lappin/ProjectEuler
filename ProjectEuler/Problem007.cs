
public class Problem7
{


	public static long Solve()
	{

		int count = 0;

		for (long i = 2; i < 9223372036854775807L; i++)
		{
			if (isPrime(i))
			{
				count++;
				if (count == 10001)
				{
					return i;
				}
			}
		}
		return 0;
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
}
