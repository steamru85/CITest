using System;
using NUnit.Framework;
using ContiniousIntegration;

namespace Test
{
    [TestFixture]
    public class SomeLogicTests
    {
        [Test]
        public void Sum_BaseScenario_SumIsCorrect()
        {
            Assert.True(new SomeLogic().Sum(1,1) == 2);
        }
        
        [Test]
        public void Sum_BaseScenario_MultiplyIsCorrect()
        {
            Assert.True(new SomeLogic().Multiply(1,1) == 1);
        }
        
        [Test]
        public void Sum_BaseScenario_DivideIsCorrect()
        {
            Assert.True(new SomeLogic().Divide(1,1) == 1);
        }
        
        
        [Test]
        public void Sum_BaseScenario_SubtractIsCorrect()
        {
            Assert.True(new SomeLogic().Subtract(1,1) == 0);
        }
    }
}