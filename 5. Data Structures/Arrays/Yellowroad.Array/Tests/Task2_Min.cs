using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tasks;

namespace Tests
{
    [TestClass]
    public class Task2_Min
    {
        [TestMethod]
        public void ShouldReturnTheSmallestItem()
        {
            int[] input = { 1, 2, 3, 4, 5 };
            var minimumFinder = new MinimumFinder();
            int result = minimumFinder.Find(input);
            Assert.AreEqual(1, result);
        }
    }
}