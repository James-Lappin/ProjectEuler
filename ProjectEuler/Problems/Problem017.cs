
public class Problem17
{

	public int Solve()
	{
		int result = 0;

		string[] numbersWrittenAsWords = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine",
										"ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen",
										"twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety","hundred","thousand"
										};

		for (int i = 1; i <= 20; i++)
		{
			result = result + numbersWrittenAsWords[i].Length;
		}

		for (int i = 21; i < 100; i++)
		{
			int single = i % 10;
			result = result + numbersWrittenAsWords[single].Length;


		}

		result = 56 / 10;
		return result;
	}

}
