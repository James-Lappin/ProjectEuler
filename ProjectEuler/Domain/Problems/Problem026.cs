using System;
using ProjectEuler.Domain.ExtensionMethods;
using ProjectEuler.Domain.Interfaces;

namespace ProjectEuler.Domain.Problems
{
	public class Problem026 : IProblem
	{
		public string Solve()
		{
			for (var i = 0; i < 1000; i++)
			{
				if (i.IsPrime())
				{
					var x = (double) 1/i;
					
				}
			}

			throw new NotImplementedException();
		}
	}
}
