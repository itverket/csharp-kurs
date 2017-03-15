using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Reflection;

namespace CSharpKurs.TestMethods
{
    [TestClass]
    public class FunWithGenericsTestMethods
    {
        private readonly FunWithGenerics _funWithGenerics = new FunWithGenerics();
        private readonly FunWithGenerics2 _funWithGenerics2 = new FunWithGenerics2();
        private readonly FunWithGenerics3 _funWithGenerics3 = new FunWithGenerics3();
        private readonly FunWithGenerics4 _funWithGenerics4 = new FunWithGenerics4();

        [TestMethod]
        public void MyVeryOwnListShouldTakeGenericParameter()
        {
            var types = _funWithGenerics.GetType().GetNestedTypes(BindingFlags.Public);
            var myVeryOwnList = types[0];
            var genericTypeArguments = myVeryOwnList.GetGenericArguments().Length;

            Assert.AreEqual(1, genericTypeArguments);
        }

        [TestMethod]
        public void MyVeryOwnList2ShouldHaveGenericArray()
        {
            var myVeryOwnList2 = new FunWithGenerics2.MyVeryOwnListWithGenericArray<int>();

            var TestMethod = new[] { 1, 2 };

            var properties = myVeryOwnList2.GetType().GetProperties();

            if (properties.Length == 1)
            {
                Assert.AreEqual(TestMethod.GetType(), properties[0].PropertyType);
            }
            else
            {
                Assert.AreEqual(true, false);
            }
            
        }

        [TestMethod]
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

        [TestMethod] 
        public void MyVeryOwnListWithSumAll()
        {
            var myVeryOwnList4 = new FunWithGenerics4.MyVeryOwnListWithSumAll<FunWithGenerics4.ISummable>();
            FunWithGenerics4.ISummable[] list = new FunWithGenerics4.ISummable[0];
            myVeryOwnList4.List = list;

            var TestMethod1 = new Summable(1);
            var TestMethod2 = new Summable(2);
            var TestMethod3 = new Summable(3);

            var types = _funWithGenerics4.GetType().GetNestedTypes(BindingFlags.Public);
            Type constructed = types[1].MakeGenericType(myVeryOwnList4.GetType().GenericTypeArguments);

            var addMethod = constructed.GetMethod("Add");

            addMethod.Invoke(myVeryOwnList4, new object[] { TestMethod1 });
            addMethod.Invoke(myVeryOwnList4, new object[] { TestMethod2 });
            addMethod.Invoke(myVeryOwnList4, new object[] { TestMethod3 });

            var sumAllMethod = constructed.GetMethod("SumAll");

            var value = sumAllMethod.Invoke(myVeryOwnList4, null);

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
