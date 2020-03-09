using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            int lenght = lists.Length;
            if (lenght == 0) 
            {
                return null;
            }
            while (lenght > 1)
            {
                for (int i = 0; i < lenght / 2; i++)
                {
                    lists[i] = MergeTwoLists(lists[i], lists[lenght/2 + i]);
                }
                lenght = lenght/ 2;
            }
            return lists[0];

        }
    }
}
