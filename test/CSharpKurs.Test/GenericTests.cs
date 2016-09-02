using NUnit.Framework;
using static CSharpKurs.FunWithGenerics;

namespace CSharpKurs.Tests
{
    [TestFixture]
    public class FunWithGenericsTests
    {
        private FunWithGenerics _myVeryOwnList = new FunWithGenerics();

        [Test]
        public void MyVeryOwnListShouldTakeGenericParameter()
        {
            var myVeryOwnList = new MyVeryOwnListOfGenericType<int>();
            var genericTypeArguments = myVeryOwnList.GetType().GenericTypeArguments.Length;

            Assert.AreEqual(1, genericTypeArguments);
        }

        [Test]
        public void MyVeryOwnList2ShouldHaveGenericArray()
        {
            var myVeryOwnList2 = new MyVeryOwnListWithGenericArray<int>();
        }
    }
}
