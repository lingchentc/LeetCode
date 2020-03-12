using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution2
    {

        public bool IsMatch(string s, string p)
        {
            if (p == s || p == "*")
            {
                return true;
            }

            if (p == "" || s == "")
            {
                return false;
            }
            int sIndex = 0, pIndex = 0, sTemp = -1, pTemp = -1;
            while (sIndex < s.Length)
            {
                if (pIndex < p.Length && (p[pIndex] == '?'|| p[pIndex] == s[sIndex]))//字符与？号匹配
                {
                    pIndex++;
                    sIndex++;
                }
               
                else if (pIndex < p.Length && p[pIndex] == '*')
                {
                    while (pIndex < p.Length - 1)//消除连续的* 
                    {
                        if (p[pIndex + 1] == '*')
                        {
                            pIndex++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (pIndex == p.Length - 1)//前面已匹配完毕，最后只剩一个* 则全匹配 
                    {
                        return true;
                    }
                    pIndex++;//匹配掉*号
                    pTemp = pIndex;
                    sTemp = sIndex;


                }
                else if (sTemp == -1)//无*号情况下匹配不上 
                {
                    return false;
                }
                else//有星号的情况下匹配不上，回溯并将sTemp向前推进1位
                {
                    pIndex = pTemp;
                    sTemp++;
                    sIndex = sTemp;
                }
                
            }
            for (int i = pIndex; i < p.Length; i++)
            {
                if (p[i] != '*') 
                {
                    return false;
                } 
            }
            return true;
        }
    }
}
