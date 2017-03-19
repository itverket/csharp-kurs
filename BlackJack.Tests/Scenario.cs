using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackJack.Tests
{
    public abstract class Scenario
    {
        [TestInitialize]
        public void Setup()
        {
            Given();
            When();
        }

        public virtual void Given() { }

        public virtual void When() { }


        public class ThenAttribute : TestMethodAttribute
        {

        }

    }

}
