using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> maps = new Dictionary<char, int> { 
                { 'I', 1 }, 
                { 'V', 5 }, 
                { 'X', 10 }, 
                { 'L', 50 }, 
                { 'C', 100 }, 
                { 'D', 500 }, 
                { 'M', 1000 }
            };
            if (s.Length == 0)//0 
            {
                return 0;
            }
            if (s.Length == 1) 
            {
                return maps[s[0]];
            }
            int i = 0;
            int result = 0;
            while (i < s.Length) 
            {
                if (i + 1 < s.Length)//有两位以上
                {
                    int n1 = maps[s[i]];
                    int n2 = maps[s[i + 1]];
                    if (n1 < n2)// 左边数值小于右边
                    {
                        result += (n2 - n1);
                        i += 2;
                        
                    }
                    else//左边数值大于右边
                    {
                        result += n1;
                        i++;
                    }
                }
                else
                {
                    result += maps[s[i]];
                    i++;
                }
            }
            return result;
        }
    }
}
