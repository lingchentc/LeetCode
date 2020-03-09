using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        //映射表
        private Dictionary<char, char[]> _digitsDic = new Dictionary<char, char[]>
        {
            { '2', new char[] {'a','b','c' } },
            { '3', new char[] {'d','e','f' } },
            { '4', new char[] {'g','h','i' } },
            { '5', new char[] {'j','k','l' } },
            { '6', new char[] {'m','n','o' } },
            { '7', new char[] {'p','q','r','s' } },
            { '8', new char[] {'t','u','v' } },
            { '9', new char[] {'w','x','y','z' } }
        };
        public IList<string> LetterCombinations(string digits)
        {
            IList<string> result = new List<string>();
            if (string.IsNullOrEmpty(digits))//输入为空则返回空
            {
                return result;
            }
            

            int index = 0;
            result = LetterCombinations(digits, index);//进行递归
            return result;
        }

        private IList<string> LetterCombinations(string digits, int index)
        {
            IList<string> result = new List<string>();
            if (index < digits.Length - 1)//不是最后一位
            {
                IList<string> next = LetterCombinations(digits, index + 1);//取下一位的结果
                for (int i = 0; i < _digitsDic[digits[index]].Length; i++)
                {
                    for (int j = 0; j < next.Count; j++)//遍历结果加上前一位
                    {
                        result.Add($"{_digitsDic[digits[index]][i]}{next[j]}");
                    }
                }
            }
            else//最后一位
            {
                for (int i = 0; i < _digitsDic[digits[index]].Length; i++)
                {
                    result.Add($"{_digitsDic[digits[index]][i]}");
                }
            }
            return result;
        }
    }
}
