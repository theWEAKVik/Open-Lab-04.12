using System;
using System.Collections;
using System.Linq;
using NUnit.Framework;

namespace Open_Lab_04._12
{
    [TestFixture]
    public class Tests
    {

        private Numbers numbers;

        private const int RandSeed = 412412412;
        private const int RandTestCasesCount = 97;

        [OneTimeSetUp]
        public void Init() => numbers = new Numbers();

        [TestCase(new []{ 1, 2, 3, 4, 6, 7, 8, 9, 10 }, 5)]
        [TestCase(new []{ 7, 2, 3, 6, 5, 9, 1, 4, 8 }, 10)]
        [TestCase(new []{ 10, 5, 1, 2, 4, 6, 8, 3, 9 }, 7)]
        [TestCaseSource(nameof(GetRandom))]
        public void MissingNumTest(int[] nums, int expected) =>
            Assert.That(numbers.MissingNum(nums), Is.EqualTo(expected));

        private static IEnumerable GetRandom()
        {
            var rand = new Random(RandSeed);

            for (var i = 0; i < RandTestCasesCount; i++)
            {
                var expected = rand.Next(1, 11);

                yield return new TestCaseData(
                    Enumerable.Range(1, 10).Where(num => num != expected).OrderBy(n => rand.Next()).ToArray(), 
                    expected);
            }
        }
    }
}