using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public double MyPow(double x, int n)
        {
            if (n == 0||x==1)//特例 
            {
                return 1;
            }
            bool flag = n > 0;//判断指数正负
            double dN = n;//改用double防止绝对值越界
            dN = Math.Abs(dN);//取得绝对值
           
            double temp = doPow(x, dN);
            
            if (flag)
            {
                return temp;
            }
            else
            {
                return 1 / temp;
            }

        }

        private double doPow(double x, double n)
        {
            double result = 1;
            if (n <= 3)
            {
                for (int i = 0; i < n; i++)
                {
                    result *= x;
                }
            }
            else
            {
                int rem =(int) n % 2;//检测单双数
                n -= rem;
                result = doPow(x, n / 2);
                result = result * result;
                for (int i = 0; i < rem; i++)
                {
                    result *= x;
                }
            }
            return result;
        }
    }
}
