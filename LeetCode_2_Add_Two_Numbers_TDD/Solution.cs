﻿using System.Collections.Generic;

namespace LeetCode_2_Add_Two_Numbers_TDD
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int x) { val = x; }
     * }
     */

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return CreateSumNode(l1, l2, 0);
        }

        private ListNode CreateSumNode(ListNode l1, ListNode l2, int carry)
        {
            if (l1 == null && l2 == null)
            {
                return carry == 0 ? null : new ListNode(carry);
            }

            var nodeSum = NodeSum(l1, l2, carry);

            var result = new ListNode(nodeSum % 10);

            var carryToHigherDigit = nodeSum >= 10 ? 1 : 0;
            result.next = CreateSumNode(l1?.next ?? null, l2?.next ?? null, carryToHigherDigit);

            return result;
        }

        private static int NodeSum(ListNode l1, ListNode l2, int carry)
        {
            var l1Val = l1?.val ?? 0;
            var l2Val = l2?.val ?? 0;

            var nodeSum = carry + l1Val + l2Val;
            return nodeSum;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x)
        {
            val = x;
        }

        public IEnumerable<int> All()
        {
            var result = new List<int>();
            result.Add(this.val);

            if (this.next != null)
            {
                result.AddRange(next.All());
            }

            return result;
        }
    }
}