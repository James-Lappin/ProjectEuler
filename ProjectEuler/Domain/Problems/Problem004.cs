using ProjectEuler.Domain.Interfaces;

namespace ProjectEuler.Domain.Problems
{
    public class Problem004 : IProblem
    {
        public string Solve()
        {
            var result = 0;

            for (var i = 999; i > 101; i--)
            {
                for (var j = 999; j > 101; j--)
                {
                    var number = i * j;
                    if (number == ReverseInt(number) && number > result)
                    {
                        result = number;
                    }
                }
            }

            return result.ToString();
        }

        public int ReverseInt(int input)
        {
            var dave = input.ToString();

            throw new System.NotImplementedException();
            //return int.Parse(new StringBuilder(dave).Reverse().toString());
        }
    }
}