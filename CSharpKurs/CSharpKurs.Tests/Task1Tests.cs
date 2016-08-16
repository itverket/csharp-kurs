using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace CSharpKurs.Tests
{
    [TestFixture]
    public class Task1Tests
    {

        private readonly Task1 _task1 = new Task1();


        [Test]
        public void Add()
        {
            _task1.Add(1, 2).Should().Be(3);
        }
    }
}
