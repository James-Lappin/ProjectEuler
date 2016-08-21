namespace ProjectEuler.Problems
{
    public class Problem14
    {
        public int Solve()
        {
            int result = 0;
            int biggestCount = 0;

            for (int i = 2; i < 1000000; i++)
            {
                long sequence = i;
                int count = 1;

                while (sequence != 1)
                {
                    if (sequence < 0)
                    {
                        int hgfsah = 0;
                        int has = hgfsah;
                        hgfsah = has;
                    }

                    if (sequence % 2 == 0)
                    {
                        sequence = sequence / 2;
                    }
                    else
                    {
                        sequence = (3 * sequence) + 1;
                    }
                    count++;
                }

                if (count > biggestCount)
                {
                    biggestCount = count;
                    result = i;
                }
            }

            return result;
        }
    }
}