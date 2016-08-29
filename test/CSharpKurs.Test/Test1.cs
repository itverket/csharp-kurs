using NUnit.Framework;

namespace CSharpKurs.Tests
{
    [TestFixture]
    public class Test1
    {
        [Test]
        public void Test()
        {
            Assert.IsTrue(Class1.ReturnsTrue());
        }
    }
}
