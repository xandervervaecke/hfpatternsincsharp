using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimUDuck
{

    [TestFixture]
    internal class SuperDuckTest
    {
        private Mock<SuperDuck> mockDuck;

        [SetUp]

        public void SetUp()
        {
            mockDuck = new Mock<SuperDuck>();
        }

        [Test]
        public void TestInit()
        {
            var superDuperDuck = mockDuck.Object;
            Assert.IsInstanceOf<SuperDuck>(superDuperDuck);
            mockDuck.Verify(duck => duck.SetFly(It.IsAny<FlyWithJetPropulsion>()), Times.Once);
            mockDuck.Verify(duck => duck.SetQuack(It.IsAny<QuackLikeMallard>()), Times.Once);
        }
    }
}
