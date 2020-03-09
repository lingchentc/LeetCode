using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')//判断入栈
                {
                    stack.Push(s[i]);
                    continue;
                }
                if (s[i] == ')')//判断出栈
                {
                    if (stack.Count > 0 && stack.Peek() == '(')
                    {
                        stack.Pop();
                        continue;
                    }
                    else//匹配失败
                    {
                        return false;
                    }
                }
                
                if (s[i] == ']')//判断出栈
                {
                    if (stack.Count > 0 && stack.Peek() == '[')
                    {
                        stack.Pop();
                        continue;
                    }
                    else//匹配失败
                    {
                        return false;
                    }
                }
                
                if (s[i] == '}')//判断出栈
                {
                    if (stack.Count > 0 && stack.Peek() == '{')
                    {
                        stack.Pop();
                        continue;
                    }
                    else//匹配失败
                    {
                    return false;
                }
                }
                
            }
            return stack.Count == 0;
        }
    }
}
