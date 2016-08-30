using NUnit.Framework;
using System;
using System.Reflection;

namespace CSharpKurs.Tests
{
    [TestFixture]
    public class OptionalParametersTests
    {
        [Test]
        public void Ctor_should_set_private_field()
        {
            var optionalParameters = new OptionalParameters(1337);
            var field = (int)optionalParameters.GetType().GetField("_myNumber",
                         BindingFlags.NonPublic |
                         BindingFlags.Instance).GetValue(optionalParameters);

            Assert.AreEqual(1337, field);            
        }

        [Test]
        public void Ctor_should_have_optional_parameter()
        {
            var type = typeof(OptionalParameters);
            var ctor = type.GetConstructor(new[] { typeof(int) });
            var instance = ctor.Invoke(new object[] {Type.Missing}) as OptionalParameters;
            var field = (int)type.GetField("_myNumber",
                        BindingFlags.NonPublic |
                        BindingFlags.Instance).GetValue(instance);
            Assert.AreEqual(0, field);
        }

        [Test]
        public void OptionalStringParameter_should_use_both_parameters()
        {
            var optionalParameters = new OptionalParameters(1337);
            var greeting = optionalParameters.OptionalStringParameter("Ole", "Olsen");
            Assert.AreEqual("Hello Ole Olsen", greeting);
        }



    }
}
