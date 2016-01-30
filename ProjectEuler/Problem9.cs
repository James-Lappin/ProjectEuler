using System;

public class Problem9
{

	public static int Solve()
	{

		for (int i = 2; i < 1000; i++)
		{
			for (int j = 2; j < 1000; j++)
			{
				for (int k = 2; k < 1000; k++)
				{
					if ((Math.Pow(i, 2) + Math.Pow(j, 2) - Math.Pow(k, 2)) == 0)
					{
						if (i + j + k == 1000)
						{
							Console.WriteLine("i = " + i + "\nj = " + j + "\nk = " + k);
							return i * j * k;
						}
					}
				}
			}
		}

		return 0;
	}
}
