using ProjectEuler.Interfaces;
using System.Collections.Generic;
using System.Linq;
using ProjectEuler.ExtensionMethods;

namespace ProjectEuler.Problems
{
	public class Problem021 : IProblem
	{
		//what happens if value is 0?
		public int StartValue { get; set; } = 1;
		public int MaxValue { get; set; } = 10000;

		//What happens if one of the values is over the max value but a pair with another value?
		//e.g. max value 225
		public string Solve()
		{
			var valuesSearched = new HashSet<int>();
			var result = 0;

			for (var value = StartValue; value < MaxValue; value++)
			{
				if (valuesSearched.Contains(value)) { continue; }

				var pair = value.FindProperDivisors().Sum();
				var pairsValue = pair.FindProperDivisors().Sum();

				valuesSearched.Add(value);
				valuesSearched.Add(pair);

				if (pairsValue == pair || pairsValue != value) continue;

				result += pair;
				result += pairsValue;
			}

			return result.ToString();
		}


	}
}
