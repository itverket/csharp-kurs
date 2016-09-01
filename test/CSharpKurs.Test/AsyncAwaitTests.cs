using System;
using System.Diagnostics;
using System.Threading.Tasks;
using NUnit.Framework;

namespace CSharpKurs.Tests
{
    [TestFixture]
    public class AsyncAwaitTests
    {

        [Test]
        public async Task Should_return_in_less_than_6_seconds_and_have_two_stars()
        {
            var task = new AsyncAwait();

            Stopwatch stopwatch = Stopwatch.StartNew();
            await task.TellTheKidsToDoTheirDuties();
            stopwatch.Stop();

            Assert.That(stopwatch.Elapsed, Is.LessThan(TimeSpan.FromSeconds(6)));
            Assert.That(task.TotalStarsOnRefridgitrator, Is.EqualTo(2));
        }
    }
}
