using System;
using NUnit.Framework;

#pragma warning disable CA1707

namespace CountChars.Tests
{
    [TestFixture]
    public sealed class DoWhileMethodsTests
    {
        [Test]
        public void GetNumbersCount_StringIsNull_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => DoWhileMethods.GetNumbersCount(null));
        }

        [TestCase("", ExpectedResult = 0)]
        [TestCase("a", ExpectedResult = 0)]
        [TestCase("ab", ExpectedResult = 0)]
        [TestCase(" a b ", ExpectedResult = 0)]
        [TestCase("a1b", ExpectedResult = 1)]
        [TestCase(" a 1 b ", ExpectedResult = 1)]
        [TestCase(" 1 a 2 b 3 ", ExpectedResult = 3)]
        [TestCase("1a2b3c4", ExpectedResult = 4)]
        [TestCase(" 1 a 2 b 3 c 4 ", ExpectedResult = 4)]
        public int GetNumbersCount_ValidString_ReturnsCharsCount(string str)
        {
            return DoWhileMethods.GetNumbersCount(str);
        }

        [Test]
        public void GetNumbersCountRecursive_StringIsNull_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => DoWhileMethods.GetNumbersCountRecursive(null));
        }

        [TestCase("", ExpectedResult = 0)]
        [TestCase("a", ExpectedResult = 0)]
        [TestCase("ab", ExpectedResult = 0)]
        [TestCase(" a b ", ExpectedResult = 0)]
        [TestCase("a1b", ExpectedResult = 1)]
        [TestCase(" a 1 b ", ExpectedResult = 1)]
        [TestCase(" 1 a 2 b 3 ", ExpectedResult = 3)]
        [TestCase("1a2b3c4", ExpectedResult = 4)]
        [TestCase(" 1 a 2 b 3 c 4 ", ExpectedResult = 4)]
        public int GetNumbersCountRecursive_ValidString_ReturnsCharsCount(string str)
        {
            return DoWhileMethods.GetNumbersCountRecursive(str);
        }
    }
}
