using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public string CountAndSay(int n)
        {

            string result = "1";
            for (int i = 1; i < n; i++)
            {
                result = CountAndSya(result);
            }
            return result;
        }

        private string CountAndSya(string s) 
        {
            char currentNum = s[0];//取出第一个数字
            int times = 1;//记录次数
            string result = "";
            for (int i = 1; i < s.Length; i++)
            {
                if (currentNum == s[i])//字符相同增加次数
                {
                    times++;
                }
                else//不同生成字符串
                {
                    result += $"{times}{currentNum}";
                    currentNum = s[i];
                    times = 1;
                }
            }
            result += $"{times}{currentNum}";//将最后一次记录生成
            return result;
        }
    }
}
