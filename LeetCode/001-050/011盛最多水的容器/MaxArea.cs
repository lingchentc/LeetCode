using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int MaxArea(int[] height)
        {
            int max = 0, i = 0, j = height.Length - 1; //定义max，i，j的初始值，i j 分别在数组两端
            while (i != j) //i j 相等时两条线重合，即为结束
            {
                max = Math.Max(max, Math.Min(height[i], height[j]) * (j - i));
                if (height[i] > height[j]) //height[i]长，移动 height[j]
                {
                    j--;
                }
                else //height[j]长，移动 height[i]
                {
                    i++;
                }
            }
            return max;
        }
    }
}
