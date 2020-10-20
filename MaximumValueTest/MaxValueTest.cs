using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMaximumWithGenerics;

namespace MaximumValueTest
{
    [TestClass]
    public class MaxValueTest
    {
        [TestMethod]
        public void GivenIntegerArray_ShouldReturnLargestInteger()
        {
            int[] values = { 3, 6, 7, 10, 4, 8 };
            MaximumValue<int> maximumNumber = new MaximumValue<int>(values);

            int max = maximumNumber.GetMaximum();

            Assert.AreEqual(10, max);
        }

        [TestMethod]
        public void GivenDoubleArray_ShouldReturnLargestDouble()
        {
            double[] values = { 10.6, 25.9, 8.2, 9.56, 20.8, 6.9, 21.5 };
            MaximumValue<double> maximumNumber = new MaximumValue<double>(values);

            double max = maximumNumber.GetMaximum();

            Assert.AreEqual(25.9, max);
        }

        [TestMethod]
        public void GivenStringArrayShouldReturnLargestString()
        {
            string[] values = { "222", "498", "999", "333", "777", "888" };
            MaximumValue<string> maximumNumber = new MaximumValue<string>(values);

            string max = maximumNumber.GetMaximum();

            Assert.AreEqual("999", max);
        }
    }
}
