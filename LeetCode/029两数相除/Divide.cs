using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int Divide(int dividend, int divisor)
        {
            int result = 0;
            if (dividend == 0)//被除数为0
            {
                return 0;
            }

            if (divisor == 1) //除数为1
            {
                return dividend;
            }
            if (divisor == -1)
            {
                if (dividend > int.MinValue) // 只要不是最小的那个整数，都是直接返回相反数就好啦
                {
                    return -dividend;
                }
                else
                {
                    return int.MaxValue;//因为int.MaxValue的绝对值比int.MinValue小1 所以返回最大整数
                }
            }

            bool sign = (dividend > 0) ^ (divisor > 0); //bool的异或运算来确定两个数的符号是否相同

            long absDividend = Math.Abs((long)dividend); //转成long防止越界
            long absDivisor = Math.Abs((long)divisor);


            /* for (result = 0; absDividend >= absDivisor; result++)
             {
                 absDividend -= absDivisor;
             }*/

            result = MyDivide(absDividend, absDivisor);

            if (sign) 
            {
                result = -result;
            }
            return result;
        }

        private int MyDivide(long dividend, long divisor) 
        {
            if (dividend < divisor) 
            {
                return 0;
            }
            int result = 1;
            long myDivisor = divisor;//用于翻倍的除数
            while (myDivisor + myDivisor < dividend) //判断临界值
            {
                result = result+ result;//记录翻倍
                myDivisor = myDivisor+ myDivisor;//除数翻倍
            }
            return result + MyDivide(dividend - myDivisor, divisor);//将剩余部分继续翻倍相减
        }
    }
}
