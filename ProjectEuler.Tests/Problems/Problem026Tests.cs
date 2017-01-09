using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ProjectEuler.Domain.Problems;

namespace ProjectEuler.Tests.Problems
{
    public class Problem026Tests
    {
        private Problem026 _instance;

        [SetUp]
        public void SetUp()
        {
            _instance = new Problem026();
        }

        [Test]
        public void Solve_Example()
        {
            //arrange
            _instance.UpperLimit = 10;

            //act
            var actual = _instance.Solve();
            
            //assert
            Assert.That(actual, Is.EqualTo("7"));
        }

        [Test]
        public void Solve_Full()
        {
            //arrange
            //act
            var actual = _instance.Solve();

            //assert
            Assert.That(actual, Is.EqualTo("983"));
        }
    }
}
