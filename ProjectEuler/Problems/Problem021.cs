using System.Collections.Generic;

public class Problem21
{
	public int Solve()
	{
		int result = 0;
		List<int> dave = findDivisors(220);

		//TODO will this ever not return 0?
		return result;
	}

	private List<int> findDivisors(int number)
	{
		List<int> result = new List<int>();

		int limit = 0;
		if (number % 2 == 0) limit = (number / 2) + 1;
		else limit = (number + 1) / 2;

		for (int i = 1; i < limit; i++)
		{
			if (number % i == 0) result.Add(i);
		}

		return result;
	}
}
