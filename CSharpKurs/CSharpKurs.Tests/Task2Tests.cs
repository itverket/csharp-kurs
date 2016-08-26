using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace CSharpKurs.Tests
{
    [TestFixture]
    public class Task2Tests
    {

        private readonly Task2 _task = new Task2();


        [Test]
        public void Should_change_elements_to_be_only_first_character()
        {
            IEnumerable<string> listOfStrings = new List<string> {"Keep", "It", "Stupid", "Simple"};
            _task.FirstCharacterOfEachString(listOfStrings).Aggregate((x, y) => x + y).Should().Be("KISS");
        }
    }
}
