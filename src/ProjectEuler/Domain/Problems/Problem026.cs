using ProjectEuler.Domain.Interfaces;

namespace ProjectEuler.Domain.Problems
{
    public class Problem026 : IProblem
    {
        public int UpperLimit { get; set; } = 1000;

        public string Solve()
        {
            var sequenceLength = 0;
            var num = 0;

            for (var i = UpperLimit; i > 1; i--)
            {
                if (sequenceLength >= i)
                {
                    break;
                }

                var foundRemainders = new int[i];
                var value = 1;
                var position = 0;

                while (foundRemainders[value] == 0 && value != 0)
                {
                    foundRemainders[value] = position;
                    value *= 10;
                    value %= i;
                    position++;
                }

                if (position - foundRemainders[value] > sequenceLength)
                {
                    num = i;
                    sequenceLength = position - foundRemainders[value];
                }
            }

            return num.ToString();
        }
    }
}
