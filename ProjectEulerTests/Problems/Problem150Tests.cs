using NUnit.Framework;
using ProjectEuler.Problems;

namespace ProjectEulerTests.Problems
{
    public class Problem150Tests
    {
        [Test]
        public void Single()
        {
            //arrange
            var jaggedArray = new int[3][];
            jaggedArray[0] = new[] { 1 };
            jaggedArray[1] = new[] { 1, -150 };
            jaggedArray[2] = new[] { 1, 1, 1 };

            //act
            var actual = Problem150.GetSmallestSubtriangleSum(jaggedArray, 1);

            //assert
            Assert.That(actual[0], Is.EqualTo(-150));
        }

        [Test]
        public void SmallTriganle()
        {
            //arrange
            var jaggedArray = new int[3][];
            jaggedArray[0] = new[] { 1 };
            jaggedArray[1] = new[] { 1, -1 };
            jaggedArray[2] = new[] { 1, -1, -1 };

            //act
            var actual = Problem150.GetSmallestSubtriangleSum(jaggedArray, 1);

            //assert
            Assert.That(actual[0], Is.EqualTo(-3));
        }

        [Test]
        public void WholeTriangle()
        {
            //arrange
            var jaggedArray = new int[3][];
            jaggedArray[0] = new[] { -1 };
            jaggedArray[1] = new[] { -1, -1 };
            jaggedArray[2] = new[] { -1, -1, -1 };

            //act
            var actual = Problem150.GetSmallestSubtriangleSum(jaggedArray, 1);

            //assert
            Assert.That(actual[0], Is.EqualTo(-6));
        }

        [Test]
        public void Multiple()
        {
            //arrange
            var jaggedArray = new int[3][];
            jaggedArray[0] = new[] { -1 };
            jaggedArray[1] = new[] { -1, -1 };
            jaggedArray[2] = new[] { -1, -1, -1 };
            jaggedArray[2] = new[] { -1, -1, -1, -1 };

            //act
            var actual = Problem150.GetSmallestSubtriangleSum(jaggedArray, 3);

            //assert
            Assert.That(actual[0], Is.EqualTo(-10));
            Assert.That(actual[0], Is.EqualTo(-6));
            Assert.That(actual[0], Is.EqualTo(-6));
        }

        [Test]
        public void Example()
        {
            //arrange
            var jaggedArray = new int[3][];
            jaggedArray[0] = new[] { 15 };
            jaggedArray[1] = new[] { -14, -7 };
            jaggedArray[2] = new[] { 20, -13, -5 };
            jaggedArray[2] = new[] { -3, 8, 23, -26 };
            jaggedArray[2] = new[] { 1, -4, -5, -18, 5 };
            jaggedArray[2] = new[] { -16, 31, 2, 9, 28, 3 };

            //act
            var actual = Problem150.GetSmallestSubtriangleSum(jaggedArray, 5);

            //assert
            Assert.That(actual[0], Is.EqualTo(-42));
            Assert.That(actual[0], Is.EqualTo(-39));
            Assert.That(actual[0], Is.EqualTo(-26));
            Assert.That(actual[0], Is.EqualTo(-26 ));
            Assert.That(actual[0], Is.EqualTo(-25));
        }
    }
}
