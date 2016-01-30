public class Problem001 : IProblem
{
	public string Solve()
	{
		var result = 0;
		for (var i = 0; i < 1000; i++)
		{
			if (i % 3 == 0) result = result + i;
			else if (i % 5 == 0) result = result + i;
		}

		return result.ToString();
	}
}
