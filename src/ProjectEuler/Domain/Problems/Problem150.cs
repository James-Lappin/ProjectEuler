using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using ProjectEuler.Domain.Generators;
using ProjectEuler.Domain.Interfaces;

namespace ProjectEuler.Domain.Problems
{
    public class Problem150 : IProblem
    {
        public int Rows { get; set; } = 1000;

        public string Solve()
        {
            var triangle = GenerateTriangle(Rows);

            var rowSums = CalculateCumulativeSums(triangle);
            
            long minSum = 0;
            for (int i = 0; i < triangle.Length; i++)
            {
                for (int j = 0; j < triangle[i].Length; j++)
                {
                    long curSum = 0;
                    for (int k = i; k < triangle.Length; k++)
                    {
                        curSum += rowSums[k][k - i + 1 + j] - rowSums[k][j];
                        minSum = Math.Min(curSum, minSum);
                    }
                }
            }
            return minSum.ToString();
        }

        protected internal int[][] CalculateCumulativeSums(int[][] triangle)
        {
            var rowSums = new int[triangle.Length][];
            for (int i = 0; i < rowSums.Length; i++)
            {
                rowSums[i] = new int[triangle[i].Length + 1];
                rowSums[i][0] = 0;
                for (int j = 0; j <= i; j++)
                    rowSums[i][j + 1] = rowSums[i][j] + triangle[i][j];
            }
            return rowSums;
        }

        public int[][] GenerateTriangle(int rows)
        {
            var rand = new LinearCongruentialGenerator();
            var triangle = new int[rows][];
            for (var i = 0; i < triangle.Length; i++)
            {
                triangle[i] = new int[i + 1];
                for (int j = 0; j <= i; j++)
                    triangle[i][j] = rand.Next();
            }
            return triangle;
        }
    }
}
