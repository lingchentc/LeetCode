using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LeetCode
{
    public partial class Solution
    {
        public int Reverse(int x)
        {
            int result = 0;
            bool flag = x >= 0;  //正负数标志位
            int pos = Int32.MaxValue / 10; //正数最大除10后的值
            int posl = Int32.MaxValue % 10; //正数最大位数值
            int neg = Int32.MinValue / 10; //负数最小除10后的值
            int negl = Int32.MinValue % 10;//负数最小位数值
            while (x != 0) //没有变成0 即还有数字未处理完
            {
                int rem = x % 10; //取出个位
                if (flag)
                {
                    if (result > pos || (result == pos && rem > posl))//判断正数
                    {
                        return 0;
                    }
                }
                else
                {
                    if (result < neg || (result == neg && rem < negl)) //判断负数
                    {
                        return 0;
                    }
                }
                result = result * 10 + rem;//将原有的值升一位之后加上新的余数
                x = x / 10; //将位
                
            }
            return result;
        }

        public int ReverseCSharp(int x)
        {
            bool flag = x >= 0;
            double temp = x;
            if (!flag)
            {
                temp = (temp * -1);
            }
            var ReverseArray = temp.ToString().Reverse();
            var ReverseStr = string.Join("", ReverseArray);
            double result =  double.Parse(ReverseStr);
            if (flag)
            {
                if (result > Int32.MaxValue)
                {
                    return 0;
                }
            }
            else 
            {
                result = result * -1;
                if (result < Int32.MinValue)
                {
                    return 0;
                }
            }
            return (int)result;
        }
    }
}
