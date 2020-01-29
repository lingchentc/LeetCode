using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public string IntToRoman(int num)
        {
            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 }; //数值数组，用于计算
            string[] meps = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" }; //罗马数字数组，用于映射

            string result= "";
            for (int i = 0; i < 13; i++)
            {
                while (num >= values[i]) //每次都用尽可能大的数字去显示
                {
                    result += meps[i]; //链接字符
                    num -= values[i];  //减去已被映射过的数字
                }
            }
            return result;
        }
    }
}
