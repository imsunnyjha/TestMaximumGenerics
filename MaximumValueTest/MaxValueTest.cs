using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximumWithGenerics;

namespace MaximumValueTest
{
    [TestClass]
    public class MaxValueTest
    {
        [TestMethod]
        public void GivenInteger_MaxFirstNumber_ShouldReturnFirstNumber()
        {
            MaximumValue maximumNumber = new MaximumValue();

            int max = MaximumValue.GetMaximumIntegerNumber(12, -12, 7);

            Assert.AreEqual(12, max);
        }
        [TestMethod]
        public void GivenInteger_MaxSecondNumber_ShouldReturnSecondNumber()
        {
            MaximumValue maximumNumber = new MaximumValue();

            int max = MaximumValue.GetMaximumIntegerNumber(-16, 50, 2);

            Assert.AreEqual(50, max);
        }
        [TestMethod]
        public void GivenInteger_MaxThirdNumber_ShouldReturnThirdNumber()
        {
            MaximumValue maximumNumber = new MaximumValue();

            int max = MaximumValue.GetMaximumIntegerNumber(1, -20, 45);

            Assert.AreEqual(45, max);
        }
    }
}
