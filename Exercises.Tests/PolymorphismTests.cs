using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CSharpKurs.TestMethods
{
    [TestClass]
    public class PolymorphismTestMethods
    {

        [TestMethod]
        public void Should_get_sum_of_all_sizes()
        {
            OverloadShapes task = new OverloadShapes();
            task.Shapes = new List<Shape> {new Shape(), new Circle(), new Line()};
            var sizeSum = task.Shapes.Sum(s => s.Size);

            Assert.AreEqual(12, sizeSum);
            Assert.AreEqual(12, task.SumOfSize());

        }


    }
}
