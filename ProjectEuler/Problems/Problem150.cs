using ProjectEuler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class Problem150 : IProblem
    {
        public string Solve()
        {
            const int amountOfNumbers = 500500;
            const int amountOfSums = 1;

            var generateNumbers = GenerateNumbers(amountOfNumbers);
            var jaggedArray = TransformInToJaggedArray(generateNumbers);

            var smallestSubtriangleSums = GetSmallestSubtriangleSum(jaggedArray, amountOfSums);
            return string.Join(", ", smallestSubtriangleSums);
        }

        /// <summary>
        /// Generate Numbers for Euler problem 150 under the formula: 
        /// t := 0 
        ///for k = 1 up to k = 500500: 
        ///    t := (615949*t + 797807) modulo 220
        ///    sk := t−2^19
        /// </summary>
        /// <param name="numberToGenerate"></param>
        /// <returns></returns>
        public IEnumerable<int> GenerateNumbers(int numberToGenerate)
        {
            var t = 0;
            var powForS = (int)Math.Pow(2, 19);
            var powForT = powForS * 2;  //2 ^ 20

            var results = new List<int>();

            for (int k = 0; k < numberToGenerate; k++)
            {
                t = (615949 * t + 797807) % powForT;
                var s = t - powForS;
                results.Add(s);

            }
            return results;
        }

        public int[][] TransformInToJaggedArray(IEnumerable<int> input)
        {
            //Should probably have some validation for none triangle numbers. Although this will work, it may not return as user expected.
            var perRow = 1;
            var skipCount = 0;

            var enumerable = input as int[] ?? input.ToArray();
            var amounOfRowsForTriangle = AmounOfRowsForTriangle(enumerable.Length);
            var results = new int[amounOfRowsForTriangle][];
            for (var j = 0; j < amounOfRowsForTriangle; j++)
            {
                //Think theres a more efficient way to do this. 
                results[j] = enumerable.Skip(skipCount).Take(perRow).ToArray();
                skipCount += perRow;
                perRow++;
            }
            return results;
        }

        private int AmounOfRowsForTriangle(int count)
        {
            //k = (n(n+1))/2
            // n = 1/2 *( sqrt (8k + 1)- 1 )

            var sqrt = Math.Sqrt((8 * count) + 1);
            var d = sqrt - 1;
            var n = 0.5 * d;

            return (int)n;
        }

        public int[] GetSmallestSubtriangleSum(int[][] jaggedArray, int amountOfSums)
        {
            var sums = new List<int>();
            for (var i = 0; i < jaggedArray.Length; i++)
            {
                for (var j = 0; j < jaggedArray[i].Length; j++)
                {
                    var maxValues = GetMaxValueFromEnumberables(sums,
                        GetAllSumsOfSubTrianglesFromLocation(jaggedArray, i, j), amountOfSums);
                    sums = maxValues.ToList();
                }
            }

            return sums.OrderBy(x => x).Take(amountOfSums).ToArray();
        }

        private IEnumerable<int> GetMaxValueFromEnumberables(List<int> sums, IEnumerable<int> getAllSumsOfSubTrianglesFromLocation, int amount)
        {
            return sums.Concat(getAllSumsOfSubTrianglesFromLocation).OrderBy(x => x)
                .Take(amount);
        }

        private IEnumerable<int> GetAllSumsOfSubTrianglesFromLocation(int[][] jaggedArray, int y, int x)
        {
            var width = 0;
            var layers = new List<int>();
            for (var i = y; i < jaggedArray.Length; i++)
            {
                var layerSum = 0;
                width++;
                for (var j = x; j < x + width; j++)
                {
                    layerSum += jaggedArray[i][j];
                }

                layers.Add(layerSum);
            }

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