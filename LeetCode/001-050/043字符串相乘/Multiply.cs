using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public string Multiply(string num1, string num2)
        {
            if (num1 == "0" || num2 == "0") 
            {
                return "0";
            }
            if (num1 == "1") 
            {
                return num2;
            }
            if (num2 == "1") 
            {
                return num1;
            }
            int lNum1 = num1.Length;
            int lNum2 = num2.Length;
            int l = lNum1 + lNum2;
            int l1Val;  //上数
            int l2Val;  //下数
            int[] res = new int[l];//生成一个结果数组

            for (int i = lNum1 - 1; i >= 0; i--)
            {
                l1Val = num1[i] - '0';
                for (int j = lNum2 - 1; j >= 0; j--)
                {
                    l2Val = num2[j] - '0';
                    res[i + j + 1] += l1Val * l2Val;   //模拟数学乘法
                }
            }
            for (int i = l - 1; i > 0; i--)
            {
                if (res[i] > 9)
                {
                    res[i - 1] += res[i] / 10;   //大于10了就要进位
                    res[i] %= 10;
                }
            }


            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < res.Length; i++)//拼接字符串
            {
                sb.Append(res[i]);
            } 
            return sb.ToString().TrimStart('0');//去除头部0
        }
    }
}
