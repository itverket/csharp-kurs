using System;
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

            var test = new int[] { 1, 2 };

            myVeryOwnList2.list = test;

            var type = myVeryOwnList2.list.GetType();

            Assert.AreEqual(test.GetType(), type);
        }

        [Test]
        public void MyVeryOwnListWithGenericAddMethod()
        {
            var myVeryOwnList3 = new MyVeryOwnListWithGenericAddMethod<int>
            {
                list = new[] { 1, 2 }
            };

            myVeryOwnList3.Add(3);

            var expected = new int[] { 1, 2, 3 };

            Assert.AreEqual(expected, myVeryOwnList3.list);
        }

        [Test] 
        public void MyVeryOwnListWithSumAll()
        {
            var myVeryOwnList4 = new MyVeryOwnListWithSumAll<ISummable>();
            ISummable[] list = new ISummable[0];
            myVeryOwnList4.list = list;

            var test1 = new Summable(1);
            var test2 = new Summable(2);
            var test3 = new Summable(3);

            myVeryOwnList4.Add(test1);
            myVeryOwnList4.Add(test2);
            myVeryOwnList4.Add(test3);

            var value = myVeryOwnList4.SumAll();

            Assert.AreEqual(6, value);
        }


        public class Summable : ISummable
        {
            private int _number;

            public Summable(int number)
            {
                _number = number;
            }

            public int Sum()
            {
                return _number;
            }
        }
    }
}
