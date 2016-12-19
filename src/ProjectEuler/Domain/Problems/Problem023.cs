using System.Collections.Generic;
using System.Linq;
using ProjectEuler.Domain.ExtensionMethods;
using ProjectEuler.Domain.Interfaces;

namespace ProjectEuler.Domain.Problems
{
	public class Problem023 : IProblem
	{
		public int MaxValue { get; set; } = 28124;
		private List<int> AbundantNumbers { get; set; } = new List<int>();

		public string Solve()
		{
			var result = 0;
			for (var i = 1; i < MaxValue; i++)
			{
				if (i.IsAbundantNumber())
				{
					AbundantNumbers.Add(i);
				}

				if (!CanBeSumOfTwoNumbers(AbundantNumbers, i))
				{
					result += i;
				}
			}
			return result.ToString();
		}

		public bool CanBeSumOfTwoNumbers(List<int> numbers, int sum)
		{
			//There may be ways to make this more efficient. List types, not having to resort list everytime.
			return numbers.Any(number => numbers.Contains(sum - number));
		}
	}
}
