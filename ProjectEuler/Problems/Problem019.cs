using System;

public class Problem19
{

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
	public int Solve()
	{
		int result = 0;

		int dayOfTheMonth = 6;

		int i = 4;
		int j = 1901;

		// for(int j=1901; j<2001; j++){
		// for(int i = 0; i<12; i++){

		// finds the term floor(2.6m - 0.2)
		int month = findMonthValue(i);
		int y = findyValue(j, i);

		// finds the term floor(y/4)
		int year = findYearValue(y);

		int c = int.Parse(j.ToString().Substring(0, 2));
		int century = findCenturyValue(c);

		int w = (dayOfTheMonth + month + y + year + century - (2 * c)) % 7;
		if (w == 1) { result++; }

		return result;
	}

	private int findyValue(int year, int month)
	{
		int relativeYear = int.Parse(year.ToString().Substring(2));

		if (month == 0 || month == 1)
			relativeYear = relativeYear - 1;
		return relativeYear;
	}

	private int findCenturyValue(int c)
	{
		double value = c / 4;
		return (int)Math.Floor(value);
	}

	private int findYearValue(int y)
	{
		double value = y / 4;
		return (int)Math.Floor(value);
	}

	private int findMonthValue(int m)
	{
		if (m < 2) {
			m = m + 11;
		} else if (m >= 2) {
			m = m - 1;
		} else {
			throw new Exception("You gone fucked up now!");
		}

		return (int) Math.Floor((2.6 * m) - 0.2);
	}

}
