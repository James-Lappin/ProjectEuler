using ProjectEuler.Domain.ExtensionMethods;
using ProjectEuler.Domain.Interfaces;

namespace ProjectEuler.Domain.Problems
{
    public class Problem010 : IProblem
    {
        public string Solve()
        {
            long result = 0;
            for (int i = 2; i < 2000000; i++)
            {
                if (i.IsPrime())
                {
                    result = result + i;
                }
            }
            return result.ToString();
        }
    }
}