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
            var greeting = optionalParameters.OptionalStringParameter("Per", "Person");
            Assert.AreEqual("Hello Per Person", greeting);
        }

        [Test]
        public void OptionalStringParameter_should_work_with_one_parameter()
        {
            var optionalParameters = new OptionalParameters(1337);
            var method = optionalParameters.GetType().GetMethod("OptionalStringParameter");
            var result = method.Invoke(optionalParameters, new object[] { "Ole", Type.Missing });
            Assert.AreEqual("Hello Ole Olsen", result);
        }

        [Test]
        public void CanFirstParameterBeOptional_should_use_both_parameters()
        {
            var optionalParameters = new OptionalParameters(1337);
            var greeting = optionalParameters.CanFirstParameterBeOptional("Per", "Person");
            Assert.AreEqual("Hello Per Person", greeting);
        }

        [Test]
        public void CanFirstParameterBeOptional_should_work_with_one_parameter()
        {
            var optionalParameters = new OptionalParameters(1337);
            var method = optionalParameters.GetType().GetMethod("CanFirstParameterBeOptional");
            var result = method.Invoke(optionalParameters, new object[] { "Per", Type.Missing });
            Assert.AreEqual("Hello Per Olsen", result);
        }

        [Test]
        public void CanFirstParameterBeOptional_should_work_with_no_parameters()
        {
            var optionalParameters = new OptionalParameters(1337);
            var method = optionalParameters.GetType().GetMethod("CanFirstParameterBeOptional");
            var result = method.Invoke(optionalParameters, new object[] { Type.Missing, Type.Missing });
            Assert.AreEqual("Hello Ole Olsen", result);
        }
    }
}
