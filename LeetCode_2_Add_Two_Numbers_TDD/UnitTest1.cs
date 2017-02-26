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

        [TestMethod]
        public void L1_is_8_and_L2_is_6_should_return_4_1()
        {
            var l1 = new ListNode(8);
            var l2 = new ListNode(6);

            var expected = CreateListNodes(new int[] { 4, 1 });

            AssertResult(expected, l1, l2);
        }

        private static ListNode CreateListNodes(int[] nums)
        {
            if (nums.Length == 0)
            {
                return null;
            }

            var listNode = new ListNode(nums[0]);

            var currentNode = listNode;
            for (int i = 1; i < nums.Length; i++)
            {
                currentNode.next = new ListNode(nums[i]);
                currentNode = currentNode.next;
            }

            return listNode;
        }

        [TestMethod]
        public void L1_is_5_4_and_L2_is_3_should_return_8_4()
        {
            var l1 = CreateListNodes(new int[] { 5, 4 });

            var l2 = CreateListNodes(new int[] { 3 });

            var expected = CreateListNodes(new int[] { 8, 4 });

            AssertResult(expected, l1, l2);
        }

        [TestMethod]
        public void L1_is_5_and_L2_is_3_4_should_return_8_4()
        {
            var l1 = new ListNode(5);
            var l2 = CreateListNodes(new int[] { 3, 4 });
            var expected = CreateListNodes(new int[] { 8, 4 });
            AssertResult(expected, l1, l2);
        }

        [TestMethod]
        public void L1_is_5_4_and_L2_is_3_2_should_return_8_6()
        {
            var l1 = CreateListNodes(new int[] { 5, 4 });
            var l2 = CreateListNodes(new int[] { 3, 2 });
            var expected = CreateListNodes(new int[] { 8, 6 });
            AssertResult(expected, l1, l2);
        }

        [TestMethod]
        public void L1_is_5_and_L2_is_7_3_should_return_2_4()
        {
            var l1 = new ListNode(5);
            var l2 = CreateListNodes(new int[] { 7, 3 });
            var expected = CreateListNodes(new int[] { 2, 4 });
            AssertResult(expected, l1, l2);
        }

        [TestMethod]
        public void L1_is_5_4_and_L2_is_7_1_should_return_2_6()
        {
            var l1 = CreateListNodes(new int[] { 5, 4 });
            var l2 = CreateListNodes(new int[] { 7, 1 });
            var expected = CreateListNodes(new int[] { 2, 6 });
            AssertResult(expected, l1, l2);
        }

        [TestMethod]
        public void L1_is_5_4_3_and_L2_is_2_should_return_7_4_3()
        {
            var l1 = CreateListNodes(new int[] {5, 4, 3});
            var l2 = new ListNode(2);
            var expected = CreateListNodes(new int[] {7, 4, 3});
            AssertResult(expected, l1, l2);
        }

        [Ignore]
        [TestMethod]
        public void L1_is_5_4_and_L2_is_2_8_should_return_7_2_1()
        {
            var l1 = CreateListNodes(new int[] { 5, 4 });
            var l2 = CreateListNodes(new int[] { 2, 8 });
            var expected = CreateListNodes(new int[] { 7, 2, 1 });
            AssertResult(expected, l1, l2);
        }

        private static void AssertResult(ListNode expected, ListNode l1, ListNode l2)
        {
            expected.All().ToExpectedObject().ShouldEqual(new Solution().AddTwoNumbers(l1, l2).All());
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