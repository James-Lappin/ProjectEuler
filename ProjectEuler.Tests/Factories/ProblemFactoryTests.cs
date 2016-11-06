using System;
using NUnit.Framework;
using ProjectEuler.Domain.Factories;
using ProjectEuler.Domain.Problems;

namespace ProjectEuler.Tests.Factories
{
    public class ProblemFactoryTests
    {
        [TestCase(1, typeof(Problem001))]
        [TestCase(17, typeof(Problem017))]
        [TestCase(150, typeof(Problem150))]
        public void Successful(int problemNumber, Type expectedType)
        {
            //arrange
            //act
            var problem = ProblemFactory.Create(problemNumber);

            //assert
            Assert.That(problem, Is.TypeOf(expectedType));
        }

        [TestCase(10000)]
        [TestCase(-1)]
        public void Invalid(int problemNumber)
        {
            //arrange
            //act
            var problem = ProblemFactory.Create(problemNumber);

            //assert
            Assert.That(problem, Is.TypeOf(typeof(NullProblem)));
            Assert.That(problem.Solve(), Is.EqualTo("Unsolved"));
        }
    }
}
