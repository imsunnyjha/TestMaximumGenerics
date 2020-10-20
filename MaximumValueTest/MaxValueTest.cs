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
        [TestMethod]
        public void GivenDouble_MaxFirstNumber_ShouldReturnFirstNumber()
        {
            MaximumValue maximumNumber = new MaximumValue();

            double max = maximumNumber.GetMaximumDoubleNumber(30.5, 12.9, 18.6);

            Assert.AreEqual(30.5, max);
        }
        [TestMethod]
        public void GivenDouble_MaxSecondNumber_ShouldReturnSecondNumber()
        {
            MaximumValue maximumNumber = new MaximumValue();

            double max = maximumNumber.GetMaximumDoubleNumber(16.5, 50.8, 24.9);

            Assert.AreEqual(50.8, max);
        }
        [TestMethod]
        public void GivenDouble_MaxThirdNumber_ShouldReturnThirdNumber()
        {
            MaximumValue maximumNumber = new MaximumValue();

            double max = maximumNumber.GetMaximumDoubleNumber(15.9, 20.2, 45.5);

            Assert.AreEqual(45.5, max);
        }
        [TestMethod]
        public void GivenString_MaxFirstString_ShouldReturnFirstString()
        {
            MaximumValue maximumNumber = new MaximumValue();

            string max = maximumNumber.GetMaximumString("88.8", "55.99", "-111");

            Assert.AreEqual("88.8", max);
        }
        [TestMethod]
        public void GivenString_MaxSecondString_ShouldReturnSecondString()
        {
            MaximumValue maximumNumber = new MaximumValue();

            string max = maximumNumber.GetMaximumString("2.22", "99", "55");

            Assert.AreEqual("99", max);
        }
        [TestMethod]
        public void GivenString_MaxThirdString_ShouldReturnThirdString()
        {
            MaximumValue maximumNumber = new MaximumValue();

            string max = maximumNumber.GetMaximumString("4.44", "33.3", "99.99");

            Assert.AreEqual("99.99", max);
        }
    }
}
