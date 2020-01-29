using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows <= 1) 
            {
                return s;
            }
            string[] rows = new string[numRows];
            for (int i = 0; i < s.Length; i++)
            {
                rows[GetRow(i,numRows)] += s[i];
            }
            return string.Join("",rows);
        }

        private int GetRow(int i,int numRows)
        {
            int calc = i % (2*numRows-2);
            if (calc < numRows)
            {
                return calc;
            }
            else
            {
                return 2 * numRows - calc - 2;
            }
        }
    }
}
