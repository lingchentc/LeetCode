using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {

        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
           
            ListNode current = head;//记录循环指针所在的节点
            ListNode delNode = head,preNode = null;
            int count = 0;//启动计数
            while (current.next != null) 
            {
                count++;
                current = current.next;
               
                if (count >= n)//启动 
                {
                    preNode = delNode;
                    delNode = delNode.next;
                    
                }
            }
            if (preNode == null) //被删除的节点为头节点
            {
                head = head.next;
                return head;
            }
            preNode.next = delNode.next;
            return head;
        }

        /// <summary>
        /// 两次扫描
        /// </summary>
        /// <param name="head"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ListNode RemoveNthFromEndOld(ListNode head, int n)
        {
            int lenght = 1;//至少有一个，所以从1开始
            ListNode current = head;//记录循环指针所在的节点
            while (current.next != null)
            {
                lenght++;
                current = current.next;
            }
            if (lenght == 1)//如果只有1个节点
            {
                return null;
            }
            if (lenght == n) //如果要删除头节点
            {
                head = head.next;
                return head;
            }
            int index = lenght - n;//取得位置
            int i = 0;
            current = head;//记录循环指针所在的节点
            ListNode preNode = null;//记录前一个节点
            while (i < index)
            {

                i++;
                preNode = current;
                current = current.next;
            }
            preNode.next = current.next;//删除节点
            return head;
        }
    }
}
