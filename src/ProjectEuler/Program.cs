using System;
using ProjectEuler.Domain.Factories;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello and welcome to Project Euler solver!");
        var problemNumber = GetProblemNumberToSolve();

        var problem = ProblemFactory.Create(problemNumber);
        var answer = problem.Solve();

        Console.WriteLine(answer);
        Console.ReadLine();
    }

    private static int GetProblemNumberToSolve()
    {
        Console.WriteLine("Please type in the number of the problem you want to solve");
        var inputProblemNumber = Console.ReadLine();

        int.TryParse(inputProblemNumber, out int problemNumber);
        if (problemNumber == 0)
        {
            Console.WriteLine("That is not a number");
            return GetProblemNumberToSolve();
        }
        return problemNumber;
    }
}