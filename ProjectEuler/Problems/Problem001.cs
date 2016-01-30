
public class Problem1
{

	public int solveProblem1()
	{
		int result = 0;
		for (int i = 0; i < 1000; i++)
		{
			if (i % 3 == 0) result = result + i;
			else if (i % 5 == 0) result = result + i;
		}

		return result;
	}
}
