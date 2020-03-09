using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int LongestValidParentheses(string s)
        {
            Stack<int> stack = new Stack<int>();
            int max = 0;//最大长度
            int i = 0;//遍历指针
            int last = -1;//最后一个无效串的起始时是在-1的位置
            while (i < s.Length) 
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                else 
                {
                   
                    if (stack.Count > 0)//栈中有左括号
                    {
                        stack.Pop();//弹出一个左括号
                        if (stack.Count == 0)
                        {
                            max = Math.Max(max, i - last);//没有上一位就找记录位置
                        }
                        else
                        {
                            max = Math.Max(max, i - stack.Peek());//栈顶就是上一位
                        }
                    }
                    else
                    {
                        last = i;//更换上一位的位置
                    }
                }
                i++;
            }
            return max;
        }
    }
}
