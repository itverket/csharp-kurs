using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CSharpKurs.TestMethods
{
    [TestClass]
    public class ManipulaTestMethodringsTestMethods
    {
        private ManipulaTestMethodrings _manipulaTestMethodrings = new ManipulaTestMethodrings();

        [TestMethod]
        public void PlusOperatorConcatStrings()
        {
            var result = _manipulaTestMethodrings.PlusOperatorConcatStrings();

            Assert.AreEqual("Hello World", result);
        }

        [TestMethod]
        public void FormatString()
        {
            var result = _manipulaTestMethodrings.StringFormat();

            Assert.AreEqual("Hello to you too World", result);
        }

        [TestMethod]
        public void StringInterpolation()
        {
            var result = _manipulaTestMethodrings.StringInterpolation();

            Assert.AreEqual("Hello to you too World", result);
        }

        public void CheckForNullOrEmpty()
        {
            var result = _manipulaTestMethodrings.CheckForNullOrEmpty("");

            Assert.AreEqual("Empty string", result);
        }

        public void CheckForNullOrEmpty2()
        {
            var result = _manipulaTestMethodrings.CheckForNullOrEmpty(null);

            Assert.AreEqual("Empty string", result);
        }

        public void CheckForNullOrEmpty3()
        {
            var result = _manipulaTestMethodrings.CheckForNullOrEmpty("a");

            Assert.AreEqual("Hello World", result);
        }

        public void CheckForNullOrEmpty4()
        {
            var result = _manipulaTestMethodrings.CheckForNullOrEmpty("Hello World");

            Assert.AreEqual("Hello World", result);
        }
    }
}
