using ProjectEuler.Domain.ExtensionMethods;

namespace ProjectEuler.Domain.Problems
{
    public class Problem10
    {
        public long Solve()
        {
            long result = 0;
            for (int i = 2; i < 2000000; i++)
            {
                if (i.IsPrime())
                {
                    result = result + i;
                }
            }
            return result;
        }
    }
}