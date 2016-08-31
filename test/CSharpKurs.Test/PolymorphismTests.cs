using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharpKurs.Tests
{
    [TestFixture]
    public class PolymorphismTests
    {

        [Test]
        public void Should_get_sum_of_all_sizes()
        {
            OverloadShapes task = new OverloadShapes();
            task.Shapes = new List<Shape> {new Shape(), new Circle(), new Line()};
            var sizeSum = task.Shapes.Sum(s => s.Size);

            Assert.That(sizeSum, Is.EqualTo(12));
            Assert.That(task.SumOfSize(), Is.EqualTo(12));

        }


    }
}
