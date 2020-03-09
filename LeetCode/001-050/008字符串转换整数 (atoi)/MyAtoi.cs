using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace LeetCode
{
    public partial class Solution
    {
        public int MyAtoi(string str)
        {
            bool flag = true; //正数标记
            str = str.Trim(); //去除空白字符串
            int pos = Int32.MaxValue / 10; //正数最大除10后的值
            int posl = Int32.MaxValue % 10; //正数最大位数值
            int neg = Int32.MinValue / 10; //负数最小除10后的值
            int negl = Int32.MinValue % 10;//负数最小位数值

            //处理正负号问题，这个题目里（+-1，-+2都要输出0）
            if (str.StartsWith('-'))
            {
                str = str.Substring(1);
                flag = false;
            }
            else if (str.StartsWith('+'))
            {
                str = str.Substring(1);
            }
            int result = 0;
            for (int i = 0; i < str.Length; i++)
            {
                int? num = GetNum(str[i]);
                if (num.HasValue)
                {
                    if (flag)
                    {
                        if (result > pos || (result == pos && num.Value > posl))//判断正数
                        {
                            return Int32.MaxValue;
                        }
                    }
                    else
                    {
                        var temp = result * -1;//暂时转为负数
                        if (temp < neg || (temp == neg && (num.Value * -1) < negl)) //判断负数
                        {
                            return Int32.MinValue;
                        }
                    }
                    result = result * 10 + num.Value;
                }
                else
                {
                    break;
                }
            }
            if (!flag)
            {
                result = result * -1;
            }
            return result;
        }

        private int? GetNum(char c)
        {
            int? result = null;
            switch (c)
            {
                case '0':
                    result = 0;
                    break;
                case '1':
                    result = 1;
                    break;
                case '2':
                    result = 2;
                    break;
                case '3':
                    result = 3;
                    break;
                case '4':
                    result = 4;
                    break;
                case '5':
                    result = 5;
                    break;
                case '6':
                    result = 6;
                    break;
                case '7':
                    result = 7;
                    break;
                case '8':
                    result = 8;
                    break;
                case '9':
                    result = 9;
                    break;

                default:
                    break;
            }
            return result;
        }

        public int MyAtoiRex(string str) 
        {
            str = str.Trim();
            double outInt = 0;
            double.TryParse(System.Text.RegularExpressions.Regex.Match(str, @"^[\+\-]?\d+").Value, out outInt);
            return (int)Math.Max(Math.Min(outInt, Int32.MaxValue), Int32.MinValue);
        }
    }
}
