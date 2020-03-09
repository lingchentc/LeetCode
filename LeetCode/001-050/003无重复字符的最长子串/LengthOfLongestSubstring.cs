using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode._003无重复字符的最长子串
{
    public partial class Solution
    {
        public int LengthOfLongestSubstring(string s) 
        {
            int n = s.Length;
            Dictionary<char, char> checkDic = new Dictionary<char, char>(); //窗口中的字符
            int ans = 0, i = 0, j = 0;
            while (i < n && j < n)//条件 i 和 j 都没有到字符串尾部
            {
                if (!checkDic.ContainsKey(s[j]))//是否有重复字符
                {
                    checkDic.Add(s[j++],' ');   //移动 j 的位置扩大窗口
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    checkDic.Remove(s[i++]);  //移动 i 缩小窗口
                }
            }
            return ans;
        }
    }
}
