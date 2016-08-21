using ProjectEuler.Interfaces;
using ProjectEuler.Problems;
using System;
using System.Diagnostics;

namespace ProjectEuler
{
    internal class Program
	{
		private static void Main(string[] args)
		{
			var program = new Program();
			program.SolveProblem(new Problem150());

			Console.WriteLine("Press any key to continue");
			Console.ReadLine();
		}

		private void SolveProblem(IProblem problem)
		{
			var stopwatch = new Stopwatch();

			stopwatch.Start();
			var result = problem.Solve();
			stopwatch.Stop();

			Console.WriteLine(result);
			Console.WriteLine("Program took {0}ms to solve", stopwatch.ElapsedMilliseconds);
		}
	}
}
