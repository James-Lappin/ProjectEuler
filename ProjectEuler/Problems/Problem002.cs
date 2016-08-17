namespace ProjectEuler.Problems
{
    public class problem2
    {
        public int solveProblem2()
        {
            int firstNumber = 0;
            int secondNumber = 1;

            int result = 0;

            while (secondNumber < 4000000)
            {
                int fibonacci = firstNumber + secondNumber;

                if (fibonacci % 2 == 0) result = result + fibonacci;

                firstNumber = secondNumber;
                secondNumber = fibonacci;
            }

            return result;
        }
    }
}