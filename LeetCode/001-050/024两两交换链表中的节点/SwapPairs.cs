using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode current = head;
            ListNode preNode = new ListNode(-1);//记录前一个节点
            preNode.next = head;//将现在链表写入pre的后边
            ListNode result = preNode;

            while (current != null && current.next != null)
            {
                ListNode first = current;
                ListNode second = current.next; //取出需要交换的两个节点
                preNode.next = second;//将第二个节点接入上一个节点中
                first.next = second.next;//将第二个节点的下一个节点接入第一个节点
                second.next = first;//将第一个节点放入第二个节点后边
                preNode = first;//此时第一个节点即为下次循环的前一个节点
                current = first.next;//此时第一个节点的下一个即为下一次循环的起始节点
            }
            return result.next;
        }

        //递归方法
        //public ListNode SwapPairs(ListNode head)
        //{
        //    if (head == null || head.next == null) //判断是否无法组成一组
        //    {
        //        return head;
        //    }
        //    ListNode result = head.next; //第二个节点
        //    head.next = SwapPairs(result.next); //将第一个节点的next指向后边交换后的节点
        //    result.next = head;//将第二个节点的next指向第一个节点
        //    return result;
        //}
    }
}
