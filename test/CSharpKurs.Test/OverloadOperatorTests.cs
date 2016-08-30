using NUnit.Compatibility;
using NUnit.Framework;

namespace CSharpKurs.Tests
{
    [TestFixture]
    public class OverloadOperatorTests
    {

        [Test]
        public void Should_add_the_length_of_the_planks()
        {
            var plank1 = new Plank(1);
            var plank2 = new Plank(5);

            if (typeof(Plank).GetMethod("op_Addition") != null)
            {
                var resultPlank = typeof(Plank).GetMethod("op_Addition").Invoke(null, new Plank[] { plank1, plank2 });
                Assert.That(((Plank)resultPlank).Length, Is.EqualTo(6));
            }
            else
            {
                Assert.Fail();
            }



        }
    }
}