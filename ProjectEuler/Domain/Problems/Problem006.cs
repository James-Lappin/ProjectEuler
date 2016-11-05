using System;

namespace ProjectEuler.Domain.Problems
{
    public class Problem6
    {
        public double Solve()
        {
            double sumOfTheSquares = 0;
            for (int i = 1; i < 101; i++)
            {
                sumOfTheSquares = sumOfTheSquares + Math.Pow(i, 2);
            }

            double sums = 0;
            for (int i = 1; i < 101; i++)
            {
                sums = sums + i;
            }
            double squareOfTheSums = Math.Pow(sums, 2);

            return squareOfTheSums - sumOfTheSquares;
        }
    }
}