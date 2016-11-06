using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;
using ProjectEuler.Domain.Interfaces;
using ProjectEuler.Domain.Problems;

namespace ProjectEuler.Domain.Factories
{
    public class ProblemFactory
    {
        public static IProblem Create(int problemNumber)
        {
            var paddedProblemNumber = problemNumber.ToString().PadLeft(3, '0');
            
            var type = Type.GetType($"ProjectEuler.Domain.Problems.Problem{paddedProblemNumber}", false);
            if (type == null)
            {
                return new NullProblem();
            }
            
            return Activator.CreateInstance(type) as IProblem ?? new NullProblem();
        }
    }
}
