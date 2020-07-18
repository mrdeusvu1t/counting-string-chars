using System;
using NUnit.Framework;

#pragma warning disable CA1707

namespace CountingStringChars.Tests
{
    [TestFixture]
    public sealed class ForEachMethodsTests
    {
        [Test]
        public void GetCharsCount_StringIsNull_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => ForEachMethods.GetCharsCount(null, _ => true));
        }

        [Test]
        public void GetCharsCount_FuncIsNull_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => ForEachMethods.GetCharsCount(string.Empty, null));
        }

        [TestCase("", ExpectedResult = 0)]
        [TestCase(" ", ExpectedResult = 1)]
        [TestCase("  ", ExpectedResult = 2)]
        [TestCase("   ", ExpectedResult = 3)]
        [TestCase("a", ExpectedResult = 0)]
        [TestCase(" a", ExpectedResult = 1)]
        [TestCase("a ", ExpectedResult = 1)]
        [TestCase(" a ", ExpectedResult = 2)]
        public int GetCharsCount_IsSpace_ReturnsCharsCount(string str)
        {
            return ForEachMethods.GetCharsCount(str, c => char.IsWhiteSpace(c));
        }

        [Test]
        public void GetCharsCountRecursive_StringIsNull_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => ForEachMethods.GetCharsCountRecursive(null, _ => true));
        }

        [Test]
        public void GetCharsCountRecursive_FuncIsNull_ThrowsException()
        {
            Assert.Throws<ArgumentNullException>(() => ForEachMethods.GetCharsCountRecursive(string.Empty, null));
        }

        [TestCase("", ExpectedResult = 0)]
        [TestCase(" ", ExpectedResult = 1)]
        [TestCase("  ", ExpectedResult = 2)]
        [TestCase("   ", ExpectedResult = 3)]
        [TestCase("a", ExpectedResult = 0)]
        [TestCase(" a", ExpectedResult = 1)]
        [TestCase("a ", ExpectedResult = 1)]
        [TestCase(" a ", ExpectedResult = 2)]
        public int GetCharsCountRecursive_IsSpace_ReturnsCharsCount(string str)
        {
            return ForEachMethods.GetCharsCountRecursive(str, c => char.IsWhiteSpace(c));
        }
    }
}
