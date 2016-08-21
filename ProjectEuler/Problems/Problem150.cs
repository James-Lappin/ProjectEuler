using ProjectEuler.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem150 : IProblem
    {
        public string Solve()
        {
            const int amountOfSums = 5;
            var jaggedArray = new int[6][];
            jaggedArray[0] = new[] { 15 };
            jaggedArray[1] = new[] { -14, -7 };
            jaggedArray[2] = new[] { 20, -13, -5 };
            jaggedArray[3] = new[] { -3, 8, 23, -26 };
            jaggedArray[4] = new[] { 1, -4, -5, -18, 5 };
            jaggedArray[5] = new[] { -16, 31, 2, 9, 28, 3 };

            return GetSmallestSubtriangleSum(jaggedArray, amountOfSums).ToString();
        }

        public int[] GetSmallestSubtriangleSum(int[][] jaggedArray, int amountOfSums)
        {
            var sums = new List<int>();
            for (var i = 0; i < jaggedArray.Length; i++)
            {
                for (var j = 0; j < jaggedArray[i].Length; j++)
                {
                    sums.AddRange(GetAllSumsOfSubTrianglesFromLocation(jaggedArray, i, j));
                }
            }

            return sums.OrderBy(x => x).Take(amountOfSums).ToArray();
        }

        private IEnumerable<int> GetAllSumsOfSubTrianglesFromLocation(int[][] jaggedArray, int y, int x)
        {
            var width = 0;
            var layers = new List<int>();
            for (var i = y; i < jaggedArray.Length; i++)
            {
                var layerSum = 0;
                width ++;
                for (var j = x; j < x + width; j++)
                {
                    layerSum += jaggedArray[i][j];
                }

                layers.Add(layerSum);
            }

            "kjdsf".Split(' ');

            return GetSumsFromLayers(layers);
        }

        private IEnumerable<int> GetSumsFromLayers(List<int> layers)
        {
            var sums = new List<int>();
            var runningTotal = 0;

            foreach (var layer in layers)
            {
                runningTotal += layer;
                sums.Add(runningTotal);
            }

            return sums; 
        }
    }
}