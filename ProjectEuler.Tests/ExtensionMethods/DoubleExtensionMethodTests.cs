using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using ProjectEuler.Domain.ExtensionMethods;

namespace ProjectEuler.Tests.ExtensionMethods
{
    public class DoubleExtensionMethodTests
    {
        [TestCase(123, false)]
        [TestCase(123.0, false)]
        [TestCase(123.456, true)]
        [TestCase(0.123, true)]
        public void HasRemainder(double value, bool expected)
        {
            // act
            var actual = value.HasRemainder();

            // assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}
