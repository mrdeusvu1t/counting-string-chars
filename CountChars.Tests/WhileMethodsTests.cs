using System;
using NUnit.Framework;

#pragma warning disable CA1707

namespace CountChars.Tests
{
    [TestFixture]
    public sealed class WhileMethodsTests
    {
        [Test]
        public void GetSpaceCount_StringIsNull_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => WhileMethods.GetSpaceCount(null));
        }

        [TestCase("", ExpectedResult = 0)]
        [TestCase("a", ExpectedResult = 0)]
        [TestCase("ab", ExpectedResult = 0)]
        [TestCase("abc", ExpectedResult = 0)]
        [TestCase("a b", ExpectedResult = 1)]
        [TestCase(" a b", ExpectedResult = 2)]
        [TestCase("a b ", ExpectedResult = 2)]
        [TestCase(" a b ", ExpectedResult = 3)]
        [TestCase("a b c", ExpectedResult = 2)]
        [TestCase(" a b c ", ExpectedResult = 4)]
        public int GetSpaceCount_ValidString_ReturnsCharsCount(string str)
        {
            return WhileMethods.GetSpaceCount(str);
        }

        [Test]
        public void GetSpaceCountRecursive_StringIsNull_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => WhileMethods.GetSpaceCountRecursive(null));
        }

        [TestCase("", ExpectedResult = 0)]
        [TestCase("a", ExpectedResult = 0)]
        [TestCase("ab", ExpectedResult = 0)]
        [TestCase("abc", ExpectedResult = 0)]
        [TestCase("a b", ExpectedResult = 1)]
        [TestCase(" a b", ExpectedResult = 2)]
        [TestCase("a b ", ExpectedResult = 2)]
        [TestCase(" a b ", ExpectedResult = 3)]
        [TestCase("a b c", ExpectedResult = 2)]
        [TestCase(" a b c ", ExpectedResult = 4)]
        public int GetSpaceCountRecursive_StringIsNull_ReturnsCharsCount(string str)
        {
            return WhileMethods.GetSpaceCountRecursive(str);
        }
    }
}
