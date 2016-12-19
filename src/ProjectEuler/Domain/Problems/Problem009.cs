using System;
using ProjectEuler.Domain.Interfaces;

namespace ProjectEuler.Domain.Problems
{
    public class Problem009 : IProblem
    {
        // Tis Christmas. More seriously this should be sorted
        public string Solve()
        {
            for (var i = 2; i < 1000; i++)
            {
                for (var j = 2; j < 1000; j++)
                {
                    for (var k = 2; k < 1000; k++)
                    {
                        if ((Math.Pow(i, 2) + Math.Pow(j, 2) - Math.Pow(k, 2)) == 0)
                        {
                            if (i + j + k == 1000)
                            {
                                Console.WriteLine("i = " + i + "\nj = " + j + "\nk = " + k);
                                return (i * j * k).ToString();
                            }
                        }
                    }
                }
            }

            return 0.ToString();
        }
    }
}