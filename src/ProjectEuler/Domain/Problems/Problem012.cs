using ProjectEuler.Domain.Interfaces;

namespace ProjectEuler.Domain.Problems
{
    public class Problem012 : IProblem
    {
        public string Solve()
        {
            int result = 0;
            int highestDividor = 0;
            int triangleNumber = 1;

            for (int i = 2; triangleNumber < 2147483647; i++)
            {
                triangleNumber = triangleNumber + i;
                int dave = CountDivisors(triangleNumber);

                if (dave > 500)
                {
                    result = triangleNumber;
                    break;
                }

                if (dave > highestDividor)
                {
                    highestDividor = dave;
                }
            }
            return result.ToString();
        }

        private int CountDivisors(int number)
        {
            var result = 2;
            int limit;

            if (number % 2 == 0) limit = number / 2;
            else
            {
                limit = (number - 1) / 2;
            }

            for (var i = 2; i <= limit; i++)
            {
                if (number % i == 0) result++;
            }
            return result;
        }
    }
}