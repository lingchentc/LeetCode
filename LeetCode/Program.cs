using System;
using static LeetCode.Solution;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {

            Solution s = new Solution();
            ListNode listNode = new ListNode(1);
            listNode.next = new ListNode(2);
            listNode.next.next = new ListNode(3);
            listNode.next.next.next = new ListNode(4);
            listNode.next.next.next.next = new ListNode(5);
            s.ReverseKGroup(listNode, 2);
            Console.WriteLine("Hello World");
        }
    }
}
