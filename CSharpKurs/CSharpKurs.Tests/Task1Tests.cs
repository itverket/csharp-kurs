using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace CSharpKurs.Tests
{
    [TestFixture]
    public class Task1Tests
    {

        private readonly Task1 _task = new Task1();


        [Test]
        public void Should_have_private_setter()
        {
            var props = _task.GetType().Properties();
            props.Single().SetMethod.IsPrivate.Should().BeTrue();
        }

        [Test]
        public void Should_have_getter_that_squares()
        {
            _task.MyAutoProperty.Should().Be(5); 
        }
    }
}
