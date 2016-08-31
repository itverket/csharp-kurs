using NUnit.Framework;

namespace CSharpKurs.Tests
{
    [TestFixture]
    public class ManipulateStringsTests
    {
        private ManipulateStrings _manipulateStrings = new ManipulateStrings();

        [Test]
        public void PlusOperatorConcatStrings()
        {
            var result = _manipulateStrings.PlusOperatorConcatStrings();

            Assert.AreEqual("Hello World", result);
        }

        [Test]
        public void FormatString()
        {
            var result = _manipulateStrings.StringFormat();

            Assert.AreEqual("Hello to you too World", result);
        }

        [Test]
        public void StringInterpolation()
        {
            var result = _manipulateStrings.StringInterpolation();

            Assert.AreEqual("Hello to you too World", result);
        }

        [TestCase("", "Empty string")]
        [TestCase(null, "Empty string")]
        [TestCase("a", "Hello World")]
        [TestCase("Hello World", "Hello World")]
        public void CheckForNullOrEmpty(string input, string expected)
        {
            var result = _manipulateStrings.CheckForNullOrEmpty(input);

            Assert.AreEqual(expected, result);
        }
    }
}
