using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2) 
        {
            ListNode result = null;
            if (l1 == null)//l1 为空 则l2 即为结果
            {
                result = l2;
            }
            else if (l2 == null)//l2 为空 则l1 即为结果
            {
                result = l1;
            }
            else
            {
                if (l1.val > l2.val)//选择出第一个节点
                {
                    result = l2;
                    l2 = l2.next;
                }
                else
                {
                    result = l1;
                    l1 = l1.next;
                }
                ListNode current = result;//正在操作的节点
                while (l1 != null || l2 != null) 
                {
                    if (l1 == null)//如果l1为空，只要将l2接入即可
                    {
                        current.next = l2;
                        l2 = null;
                    }
                    else if (l2 == null)//如果l2为空，只要将l1接入即可
                    {
                        current.next = l1;
                        l1 = null;
                    }
                    else
                    {
                        if (l1.val > l2.val)//比较两个节点，将小的接入
                        {
                            current.next = l2;
                            l2 = l2.next;
                            current = current.next;
                        }
                        else
                        {
                            current.next = l1;
                            l1 = l1.next;
                            current = current.next;
                        }
                    }

                }
            }
            return result;
        }
    }
}
