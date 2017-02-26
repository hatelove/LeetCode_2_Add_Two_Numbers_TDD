using System.Collections.Generic;

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
            var rootSum = l1.val + l2.val;
            var rootVal = rootSum % 10;

            var result = new ListNode(rootVal);
            if (rootSum >= 10 || l1.next != null || l2.next != null)
            {
                var carry = rootSum >= 10 ? 1 : 0;
                var l1NextVal = l1.next?.val ?? 0;
                var l2NextVal = l2.next?.val ?? 0;

                result.next = new ListNode(carry + l1NextVal + l2NextVal);
            }

            return result;
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