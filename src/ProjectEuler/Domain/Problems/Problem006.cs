using System;
using ProjectEuler.Domain.Interfaces;

namespace ProjectEuler.Domain.Problems
{
    public class Problem006 : IProblem
    {
        public string Solve()
        {
            double sumOfTheSquares = 0;
            for (var i = 1; i < 101; i++)
            {
                sumOfTheSquares = sumOfTheSquares + Math.Pow(i, 2);
            }

            double sums = 0;
            for (var i = 1; i < 101; i++)
            {
                sums = sums + i;
            }
            var squareOfTheSums = Math.Pow(sums, 2);

            return (squareOfTheSums - sumOfTheSquares).ToString();
        }
    }
}