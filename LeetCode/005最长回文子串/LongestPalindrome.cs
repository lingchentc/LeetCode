using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public string LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) //空字符串不用检查
            {
                return "";
            }
            int pos = 0;//回文启示点
            int maxLen = 1;//回文长度
            for (int i = 0; i < s.Length; ++i)
            {
                int lenghtS = IsPalindromeSingular(s, i);//假设为奇数
                if (lenghtS > maxLen) 
                {
                    maxLen = lenghtS;
                    pos = i - (lenghtS - 1) / 2;
                }
                int lenghtP = IsPalindromePlural(s, i); //假设为偶数
                if (lenghtP > maxLen) 
                {
                    maxLen = lenghtP;
                    pos = i - (lenghtP - 1) / 2;
                }

            }
            return s.Substring(pos, maxLen);

        }

        /// <summary>
        /// 奇数计算
        /// </summary>
        /// <param name="s"></param>
        /// <param name="center"></param>
        /// <returns></returns>
        private int IsPalindromeSingular(string s, int center) 
        {
            int lenght = 0; //回文长度
            bool flag = false; //是否是回文
            int left = center - 1; //左边位置
            int right = center + 1; //右边位置
            while (left >= 0 && right < s.Length && s[left] == s[right]) 
            {
                flag = true;
                left--;
                right++;
            }
            if (flag)
            {
                lenght = right - left - 1;
            }
            return lenght;
        }
        /// <summary>
        /// 偶数计算
        /// </summary>
        /// <param name="s"></param>
        /// <param name="center"></param>
        /// <returns></returns>
        private int IsPalindromePlural(string s, int center) 
        {
            int lenght = 0; //回文长度
            bool flag = false; //是否是回文
            int left = center; //左边位置
            int right = center + 1; //右边位置
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                flag = true;
                left--;
                right++;
            }
            if (flag)
            {
                lenght = right - left - 1;
            }
            return lenght;
        }
    }
}
