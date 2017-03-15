using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CSharpKurs.TestMethods
{
    [TestClass]
    public class AsyncAwaitTestMethods
    {

        [TestMethod]
        public async Task Should_return_in_less_than_6_seconds_and_have_two_stars()
        {
            var task = new AsyncAwait();

            Stopwatch stopwatch = Stopwatch.StartNew();
            await task.TellTheKidsToDoTheirDuties();
            stopwatch.Stop();

            Assert.IsTrue(stopwatch.Elapsed < TimeSpan.FromSeconds(6));
            Assert.AreEqual(2, task.TotalStarsOnRefridgitrator);
        }
    }
}
