using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode resNode = new ListNode(-1);//链表头节点，输出的时候这个节点不要
            ListNode currNode = resNode; //当前使用的节点
            int carry = 0;//进位
            int l1Val;  //上数
            int l2Val;  //下数
            int temp;
            while (l1 != null || l2 != null || carry > 0)
            {
                l1Val = l1 == null ?0 : l1.val;
                l2Val = l2 == null ? 0 : l2.val;

                temp = l1Val + l2Val + carry;  //上数 加 下数 加 进位
                carry = temp / 10;  //获得进位的数值
                
                currNode.next = new ListNode(temp % 10);//把当前位的值写入链表
                currNode = currNode.next;

                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;//移位，但是我们知道这两个都没有下一位了
            }
            return resNode.next;
        }
    }
}
