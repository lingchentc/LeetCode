using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public IList<string> GenerateParenthesis(int n) 
        {
            IList<string> result = null;
            if (n == 0)
            {
                return new List<string>();
            }
            int cl = 0;//左括号计数
            int cr = 0;//右括号计数
            result = GenerateParenthesis(n, cl, cr);
            return result;
        }

        private IList<string> GenerateParenthesis(int n, int cl, int cr)
        {
            IList<string> result = new List<string>();
            if (cl > cr && cl < n)//条件1
            {
                IList<string> nextL = GenerateParenthesis(n, cl + 1, cr);
                IList<string> nextR = GenerateParenthesis(n, cl, cr + 1);
                for (int i = 0; i < nextL.Count; i++)
                {
                    result.Add($"({nextL[i]}");
                }
                for (int i = 0; i < nextR.Count; i++)
                {
                    result.Add($"){nextR[i]}");
                }
                return result;
            }
            else if (cl == cr && cl < n)//条件2
            {
                IList<string> nextL = GenerateParenthesis(n, cl + 1, cr);
                for (int i = 0; i < nextL.Count; i++)
                {
                    result.Add($"({nextL[i]}");
                }
                return result;
            }
            else if (cl > cr && cl == n)//条件3
            {
                IList<string> nextR = GenerateParenthesis(n, cl, cr + 1);
                for (int i = 0; i < nextR.Count; i++)
                {
                    result.Add($"){nextR[i]}");
                }
                return result;
            }
            else//条件4
            {
                result.Add("");
                return result;
            }
        }
    }
}
