using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yellowroad.Array.Tasks;

namespace Tests
{
    [TestClass]
    public class Task1_Reverse
    {
        [TestMethod]
        public void InputArrayShouldBeReversed()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6 };
            var reverseArray = new ReverseArray();
            int[] result = reverseArray.Reverse(nums);

            int[] expected = { 6, 5, 4, 3, 2, 1 };
            Assert.AreEqual(expected, result);
        }
    }
}