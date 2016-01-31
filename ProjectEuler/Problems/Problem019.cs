using ProjectEuler.Interfaces;
using System;

namespace ProjectEuler.Problems
{
	public class Problem019 : IProblem
	{
		public DateTime FinishDate { get; set; } = new DateTime(2000, 12, 31);
		public DateTime StartDate { get; set; } = new DateTime(1901, 1, 1);

		//How many Sundays fell on the first of the month during the twentieth century(1 Jan 1901 to 31 Dec 2000)?
		public string Solve()
		{
			return SolveEasy();
		}

		private string SolveEasy()
		{
			var result = 0;
			var date = StartDate;
			while (date < FinishDate)
			{
				if (date.DayOfWeek == DayOfWeek.Sunday) result++;

				date = date.AddMonths(1);
			}

			return result.ToString();
		}

		// using Disparate variation from
		// http://en.wikipedia.org/wiki/Determination_of_the_day_of_the_week
		// formula is 1 = d + floor(2.6m - 0.2) + y + floor(y/4) + floor(c/4) mod 7

		// where
		// Y is the year minus 1 for January or February, and the year for any other
		// month
		// y is the last 2 digits of Y
		// c is the first 2 digits of Y
		// d is the day of the month (1 to 31)
		// m is the shifted month (March=1,...February=12)
		// w is the day of week (0=Sunday,..6=Saturday)
		public int SolveHard()
		{
			var result = 0;

			var dayOfTheMonth = 6;

			var i = 4;
			var j = 1901;

			// for(int j=1901; j<2001; j++){
			// for(int i = 0; i<12; i++){

			// finds the term floor(2.6m - 0.2)
			var month = FindMonthValue(i);
			var y = FindyValue(j, i);

			// finds the term floor(y/4)
			var year = FindYearValue(y);

			var c = int.Parse(j.ToString().Substring(0, 2));
			var century = FindCenturyValue(c);

			var w = (dayOfTheMonth + month + y + year + century - 2 * c) % 7;
			if (w == 1)
			{
				result++;
			}

			return result;
		}

		private int FindyValue(int year, int month)
		{
			var relativeYear = int.Parse(year.ToString().Substring(2));

			if (month == 0 || month == 1)
				relativeYear = relativeYear - 1;
			return relativeYear;
		}

		private int FindCenturyValue(int c)
		{
			decimal value = c / 4;
			return (int)Math.Floor(value);
		}

		private int FindYearValue(int y)
		{
			double value = y / 4;
			return (int)Math.Floor(value);
		}

		private int FindMonthValue(int m)
		{
			if (m < 2)
			{
				m = m + 11;
			}
			else if (m >= 2)
			{
				m = m - 1;
			}
			else
			{
				throw new Exception("You gone fucked up now!");
			}

			return (int)Math.Floor(2.6 * m - 0.2);
		}
	}
}