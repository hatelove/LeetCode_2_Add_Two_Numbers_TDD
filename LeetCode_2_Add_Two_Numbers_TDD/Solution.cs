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

            var needCarry = rootSum >= 10;
            var hasL1Next = l1.next != null;
            var hasL2Next = l2.next != null;

            if (needCarry || hasL1Next || hasL2Next)
            {
                var carry = needCarry ? 1 : 0;
                var l1NextVal = l1.next?.val ?? 0;
                var l2NextVal = l2.next?.val ?? 0;

                var nextSum = carry + l1NextVal + l2NextVal;
                var nextVal = nextSum % 10;

                result.next = new ListNode(nextVal);

                var needCarry_2 = nextSum >= 10;
                var hasL1Next_2 = hasL1Next && l1.next.next != null;
                var hasL2Next_2 = hasL2Next && l2.next.next != null;

                if (needCarry_2 || hasL1Next_2 || hasL2Next_2)
                {
                    var carry_2 = needCarry_2 ? 1 : 0;
                    var l1Next_2_Val = l1.next?.next?.val ?? 0;
                    var l2Next_2_Val = l2.next?.next?.val ?? 0;
                    result.next.next = new ListNode(carry_2 + l1Next_2_Val + l2Next_2_Val);
                }
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