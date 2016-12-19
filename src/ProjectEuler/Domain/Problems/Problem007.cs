using ProjectEuler.Domain.ExtensionMethods;
using ProjectEuler.Domain.Interfaces;

namespace ProjectEuler.Domain.Problems
{
    public class Problem007 : IProblem
    {
        public string Solve()
        {
            int count = 0;

            for (long i = 2; i < 9223372036854775807L; i++)
            {
                if (i.IsPrime())
                {
                    count++;
                    if (count == 10001)
                    {
                        return i.ToString();
                    }
                }
            }
            return 0.ToString();
        }
    }
}