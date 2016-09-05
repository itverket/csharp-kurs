using System;
using System.Reflection;
using NUnit.Framework;
using static CSharpKurs.FunWithGenerics;

namespace CSharpKurs.Tests
{
    [TestFixture]
    public class FunWithGenericsTests
    {
        private readonly FunWithGenerics _funWithGenerics = new FunWithGenerics();
        private readonly FunWithGenerics2 _funWithGenerics2 = new FunWithGenerics2();
        private readonly FunWithGenerics3 _funWithGenerics3 = new FunWithGenerics3();
        //private readonly FunWithGenerics _funWithGenerics = new FunWithGenerics();
        //private readonly FunWithGenerics _funWithGenerics = new FunWithGenerics();

        [Test]
        public void MyVeryOwnListShouldTakeGenericParameter()
        {
            var types = _funWithGenerics.GetType().GetNestedTypes(BindingFlags.Public);
            var myVeryOwnList = types[0];
            var genericTypeArguments = myVeryOwnList.GetGenericArguments().Length;

            Assert.AreEqual(1, genericTypeArguments);
        }

        [Test]
        public void MyVeryOwnList2ShouldHaveGenericArray()
        {
            var myVeryOwnList2 = new FunWithGenerics2.MyVeryOwnListWithGenericArray<int>();

            var test = new[] { 1, 2 };

            var properties = myVeryOwnList2.GetType().GetProperties();

            if (properties.Length == 1)
            {
                Assert.AreEqual(test.GetType(), properties[0].PropertyType);
            }
            else
            {
                Assert.AreEqual(true, false);
            }
            
        }

        [Test]
        public void MyVeryOwnListWithGenericAddMethod()
        {
            var myVeryOwnList3 = new FunWithGenerics3.MyVeryOwnListWithGenericAddMethod<int>
            {
                List = new[] { 1, 2 }
            };

            var types = _funWithGenerics3.GetType().GetNestedTypes(BindingFlags.Public);

            Type constructed = types[0].MakeGenericType(myVeryOwnList3.GetType().GenericTypeArguments);

            var addMethod = constructed.GetMethod("Add");

            addMethod.Invoke(myVeryOwnList3, new object[] {3});

            var expected = new int[] { 1, 2, 3 };

            Assert.AreEqual(expected, myVeryOwnList3.List);
        }

        [Test] 
        public void MyVeryOwnListWithSumAll()
        {
            var myVeryOwnList4 = new FunWithGenerics4.MyVeryOwnListWithSumAll<FunWithGenerics4.ISummable>();
            FunWithGenerics4.ISummable[] list = new FunWithGenerics4.ISummable[0];
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


        public class Summable : FunWithGenerics4.ISummable
        {
            private readonly int _number;

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
