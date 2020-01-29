using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public bool IsPalindrome(int x)
        {
            if (x == 0) //为0 由于0的情况无法在后续循环中判断，故在此提前判断
            {
                return true;
            }
            if (x < 0)   //负数
            {
                return false;
            }
            if (x % 10 == 0) //个位为0
            {
                return false;
            }
            
            int temp = 0;
            while (x > 0) 
            {
                if (temp == x) //类似1221这类回文情况在此处判断
                {
                    return true;
                }
                
                int rem = x % 10;
                x = x / 10;

                if (temp == x) //类似121这类回文情况在此处判断
                {
                    return true;
                }
                temp = temp * 10 + rem;//更新temp
            }
            return false;
        }
    }
}
