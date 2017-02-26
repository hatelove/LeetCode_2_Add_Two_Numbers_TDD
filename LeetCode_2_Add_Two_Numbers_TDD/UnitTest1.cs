using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode_2_Add_Two_Numbers_TDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void L1_is_5_and_L2_is_4_should_return_9()
        {
            var l1 = new ListNode(5);
            var l2 = new ListNode(4);
            var expected = new ListNode(9);

            AssertResult(expected, l1, l2);
        }

        private static void AssertResult(ListNode expected, ListNode l1, ListNode l2)
        {
            Assert.AreEqual(expected.val, new Solution().AddTwoNumbers(l1, l2).val);
        }
    }
}