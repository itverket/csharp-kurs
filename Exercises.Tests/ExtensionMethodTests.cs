using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Reflection;

namespace CSharpKurs.TestMethods
{
    [TestClass]
    public class ExtensionMethodTestMethods
    {

        [TestMethod]
        public void Should_print_number_of_words()
        {
            if (typeof(ExtensionMethods).GetMethod("WordCount", new []{typeof(string)}) != null)
            {
                var wordCountMethodInfo = typeof (ExtensionMethods).GetMethod("WordCount", new []{ typeof(string)} );
                var count = wordCountMethodInfo.Invoke(null, new[] {"Anders Kofoed"});
                Assert.AreEqual(2, count);
            }
            else
            {
                Assert.Fail("WordCount extension method is not implemented");
            }
        }

        [TestMethod]
        public void Should_add_one_to_all_ints_in_list()
        {
            if (typeof(ExtensionMethods).GetMethod("AddToAllIntInList", new []{typeof(List<int>), typeof(int)}) != null)
            {
                var methodInfo =typeof(ExtensionMethods).GetMethod("AddToAllIntInList", new []{typeof(List<int>), typeof(int)});
                var count = (List<int>) methodInfo.Invoke(null, new object[] { new List<int>{1,2,3}, 1});
                Assert.AreEqual(2, count[0]);
                Assert.AreEqual(3, count[1]);
                Assert.AreEqual(4, count[2]);
            }
            else
            {
                Assert.Fail("AddToAllIntInList extension method is not implemented");
            }
        }


        [TestMethod]
        public void Should_count_words_of_all_strings_in_list()
        {
            var listOfStrings = new List<string> {"Keep It Simply Silly", "Sorry mama", "Anders"};
            var result = ExtensionMethods.CountWordsOfMultipleStrings(listOfStrings);
            Assert.AreEqual(7, result);
        }

    }
}