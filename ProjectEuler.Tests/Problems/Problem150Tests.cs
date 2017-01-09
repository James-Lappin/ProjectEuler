using System;
using System.Linq;
using System.Numerics;
using NUnit.Framework;
using ProjectEuler.Domain.Problems;

namespace ProjectEuler.Tests.Problems
{
    [TestFixture]
    public class Problem150Tests
    {
        private Problem150 _instance;

        [SetUp]
        public void SetUp()
        {
            _instance = new Problem150();
        }

        [Test]
        public void GenerateTriangle()
        {
            //act
            var actual = _instance.GenerateTriangle(2);

            //assert
            Assert.That(actual.Length, Is.EqualTo(2));
            Assert.That(actual[0][0], Is.EqualTo(273519));
            Assert.That(actual[1][0], Is.EqualTo(-153582));
            Assert.That(actual[1][1], Is.EqualTo(450905));
        }
        [Test]
        public void Solve10Rows()
        {
            //arrange
            _instance.Rows = 10;
            //act
            var actual = _instance.Solve();

            //assert
            Assert.That(actual, Is.EqualTo("-1495491"));
        }
        
        
        [Test]
        [Explicit("Long running")]
        public void SolveFull()
        {
            //arrange
            //act
            var actual = _instance.Solve();

            //assert
            Assert.That(actual, Is.EqualTo("-271248680"));
        }
    }
}
