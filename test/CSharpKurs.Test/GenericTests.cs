using NUnit.Framework;
using static CSharpKurs.FunWithGenerics;

namespace CSharpKurs.Tests
{
    [TestFixture]
    public class FunWithGenericsTests
    {
        private FunWithGenerics _myVeryOwnList = new FunWithGenerics();

        [Test]
        public void MyVeryOwnListSouldTakeGenericParameter()
        {
            var myVeryOwnList = new MyVeryOwnList<int>();
            var genericTypeArguments = myVeryOwnList.GetType().GenericTypeArguments.Length;

            Assert.AreEqual(1, genericTypeArguments);
        }
    }
}
