using System;
using NUnit.Framework;

#pragma warning disable CA1707

namespace CountChars.Tests
{
    [TestFixture]
    public sealed class ForMethodsTests
    {
        [Test]
        public void GetCharsCount_StringIsNull_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => ForMethods.GetCharsCount(null));
        }

        [TestCase("", ExpectedResult = 0)]
        [TestCase("a", ExpectedResult = 1)]
        [TestCase("ab", ExpectedResult = 2)]
        [TestCase("abc", ExpectedResult = 3)]
        public int GetCharsCount_ValidString_ReturnsCharsCount(string str)
        {
            return ForMethods.GetCharsCount(str);
        }

        [Test]
        public void GetCharsCountRecursive_StringIsNull_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => ForMethods.GetCharsCountRecursive(null));
        }

        [TestCase("", ExpectedResult = 0)]
        [TestCase("a", ExpectedResult = 1)]
        [TestCase("ab", ExpectedResult = 2)]
        [TestCase("abc", ExpectedResult = 3)]
        public int GetCharsCountRecursive_ValidString_ReturnsCharsCount(string str)
        {
            return ForMethods.GetCharsCountRecursive(str);
        }
    }
}
