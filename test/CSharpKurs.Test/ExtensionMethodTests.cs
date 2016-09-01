using System;
using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace CSharpKurs.Tests
{
    [TestFixture]
    public class ExtensionMethodTests
    {

        [Test]
        public void Should_print_number_of_words()
        {
            if (typeof(ExtensionMethods).GetMethod("WordCount", new []{typeof(string)}) != null)
            {
                var wordCountMethodInfo = typeof (ExtensionMethods).GetMethod("WordCount", new []{ typeof(string)} );
                var count = wordCountMethodInfo.Invoke(null, new[] {"Anders Kofoed"});
                Assert.That(count, Is.EqualTo(2));

            }
            else
            {
                Assert.Fail("WordCount extension method is not implemented");
            }
        }

        [Test]
        public void Should_add_one_to_all_ints_in_list()
        {
            if (typeof(ExtensionMethods).GetMethod("AddToAllIntInList", new []{typeof(List<int>), typeof(int)}) != null)
            {
                var methodInfo =typeof(ExtensionMethods).GetMethod("AddToAllIntInList", new []{typeof(List<int>), typeof(int)});
                var count = (List<int>) methodInfo.Invoke(null, new object[] { new List<int>{1,2,3}, 1});
                Assert.That(count[0], Is.EqualTo(2));
                Assert.That(count[1], Is.EqualTo(3));
                Assert.That(count[2], Is.EqualTo(4));

            }
            else
            {
                Assert.Fail("AddToAllIntInList extension method is not implemented");
            }
        }


        [Test]
        public void Should_count_words_of_all_strings_in_list()
        {
            var listOfStrings = new List<string> {"Keep It Simply Silly", "Sorry mama", "Anders"};
            var result = ExtensionMethods.CountWordsOfMultipleStrings(listOfStrings);
            Assert.That(result, Is.EqualTo(7));

        }

    }
}