using ExpectedObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace LeetCode_2_Add_Two_Numbers_TDD
{
    [TestClass]
    public class SolutionTests
    {
        [TestMethod]
        public void L1_is_5_and_L2_is_4_should_return_9()
        {
            var l1 = new ListNode(5);
            var l2 = new ListNode(4);
            var expected = new ListNode(9);

            AssertResult(expected, l1, l2);
        }

        [Ignore]
        [TestMethod]
        public void L1_is_8_and_L2_is_6_should_return_4_1()
        {
            var l1 = new ListNode(8);
            var l2 = new ListNode(6);
            var expected = new ListNode(4);
            expected.next = new ListNode(1);

            AssertResult(expected, l1, l2);
        }

        private static void AssertResult(ListNode expected, ListNode l1, ListNode l2)
        {
            Assert.AreEqual(expected.val, new Solution().AddTwoNumbers(l1, l2).val);
        }
    }

    [TestClass]
    public class ListNodeTests
    {
        [TestMethod]
        public void Test_All_ListNode_is_4_1()
        {
            var node = new ListNode(4);
            node.next = new ListNode(1);

            var expected = new List<int>() { 4, 1 };
            expected.ToExpectedObject().ShouldEqual(node.All());
        }
    }
}