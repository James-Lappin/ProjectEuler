using System;
using MathNet.Numerics.LinearAlgebra;

namespace ProjectEuler.Domain.Utilities
{
    public class FibonacciUtility
    {
        public static ulong FindNthFibonacciNumber(int nthNumber)
        {
            var sqrt5 = Math.Sqrt(5);
            var p1 = (1 + sqrt5)/2;
            var p2 = -1*(p1 - 1);


            var n1 = Math.Pow(p1, nthNumber);
            var n2 = Math.Pow(p2, nthNumber);
            return (ulong) ((n1 - n2)/sqrt5);
        }
    }
}