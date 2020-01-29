using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            //如果集合为空
            if (strs == null || strs.Length == 0)
            {
                return "";
            }
            //如果集合里只有一条字符串
            if (strs.Length == 1) 
            {
                return strs[0];
            }
            string operatStr = strs[0];
            //选择最短的串做操作串
            for (int i = 1; i < strs.Length; i++)
            {
                if (operatStr.Length > strs[i].Length) 
                {
                    operatStr = strs[i];
                }
            }
            string result = "";
            for (int j = 0; j < operatStr.Length; j++)
            {
                for (int i = 0; i < strs.Length; i++)
                {
                    if (strs[i][j] != operatStr[j]) 
                    {
                        return result;
                    }
                }
                result += operatStr[j];
            }
            return result;
        }
    }
}
