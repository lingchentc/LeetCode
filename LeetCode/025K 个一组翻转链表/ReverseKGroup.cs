using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode current = head;
            ListNode preNode = new ListNode(-1);//记录前一个节点
            preNode.next = head;//将现在链表写入pre的后边
            ListNode result = preNode;

            Stack<ListNode> stack = new Stack<ListNode>();//反转节点所要使用的栈
            int i = 0;
            while (current != null)//因为k个不为空的判断比较复杂，就不再这里限定
            {
                
                for (i = 0; i < k; i++)
                {
                    if (current != null)
                    {
                        stack.Push(current);//压栈
                        current = current.next;
                    }
                    else
                    {
                        break;//数量不足
                    }
                }
                if (i == k)
                {
                    while (stack.Count>0) 
                    {
                        preNode.next = stack.Pop();//出栈
                        preNode = preNode.next;
                    }
                }
                else//剩余数量不足
                {
                    break;
                }
                preNode.next = current;//链接后续的节点
            }
            return result.next;
        }
    }
}
