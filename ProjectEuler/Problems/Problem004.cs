namespace ProjectEuler.Problems
{
	public class Problem4
	{


		public int Solve()
		{
			int result = 0;

			for (int i = 999; i > 101; i--)
			{
				for (int j = 999; j > 101; j--)
				{

					int number = i * j;
					if (number == reverseInt(number) && number > result)
					{
						result = number;
					}
				}
			}

			return result;
		}


		public int reverseInt(int input)
		{
			string dave = input.ToString();


			throw new System.NotImplementedException();
			//return int.Parse(new StringBuilder(dave).Reverse().toString());
		}

	}
}
