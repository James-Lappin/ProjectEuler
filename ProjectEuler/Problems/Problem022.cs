using ProjectEuler.Interfaces;
using ProjectEuler.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ProjectEuler.ExtensionMethods;

namespace ProjectEuler.Problems
{
	public class Problem022 : IProblem
	{
		private string FileName => Directory.GetCurrentDirectory() + "../Resources/names.txt";
		private IFileUtility FileUtility { get; set; }

		public Problem022(IFileUtility fileUtility)
		{
			FileUtility = fileUtility;
		}

		public string Solve()
		{
			var orderedNames = GetOrderedNames();
			return WorkoutValueOfNames(orderedNames).ToString();
		}

		private int WorkoutValueOfNames(IReadOnlyList<string> orderedNames)
		{
			var result = 0;
			for (var i = 0; i < orderedNames.Count(); i++)
			{
				result += (i + 1) * GetNameWorth(orderedNames[i]);
			}
			return result;
		}

		private List<string> GetOrderedNames()
		{
			var names = FileUtility.ReadCsvFile(FileName);

			//Can this be made more efficient with another type of list?
			return names.ToList().Select(x => x.RemoveNonAlphanumeric())
				.OrderBy(x => x).ToList();
		}

		public int GetNameWorth(string name)
		{
			var nameAsCharacters = name.ToLower().ToCharArray();
			return nameAsCharacters.Sum(character => Convert.ToInt32(character) - 96);
		}
	}
}