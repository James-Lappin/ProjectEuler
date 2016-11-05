namespace ProjectEuler.Domain.Problems
{
    public class problem3
    {
        public long solveProblem3()
        {
            var dave = 600851475143L;

            for (long l = 2; l < dave; l++)
            {
                if (isPrime(l))
                {
                    if (dave % l == 0)
                    {
                        dave = dave / l;
                        l--;
                    }
                }
            }
            return dave;
        }

        public bool isPrime(long p)
        {
            for (long n = 2; n < p; n++)
            {
                if (p % n == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}