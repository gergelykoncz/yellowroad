using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks;

namespace Tests
{
    [TestClass]
    public class Task1_Sum
    {
        [TestMethod]
        public void ShouldReturnTheSumForIntegers()
        {
            int[] input = { 1, 2, 3, 4, 5 };
            var sumArray = new SumArray();
            int result = sumArray.Sum(input);
            Assert.AreEqual(15, result);
        }
    }
}