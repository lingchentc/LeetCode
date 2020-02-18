using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            int hLength = haystack.Length;
            int nLength = needle.Length;
            int chechLength = hLength - nLength + 1; //检测长度，如果母串剩余字符数小于子串，则无需考虑
            for (int i = 0; i < chechLength; i++)//启动遍历指针
            {
                int j = 0;// 匹配指针
                for (j = 0; j < nLength; j++)
                {
                    if (haystack[i + j] != needle[j])
                    {
                        break;
                    }
                }
                if (j == nLength)//全匹配
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
