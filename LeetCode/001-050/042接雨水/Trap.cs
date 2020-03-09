using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int Trap(int[] height)
        {
            if (height == null || height.Length == 0)
            {
                return 0;
            }
            int[] leftHeight = new int[height.Length];//每一个下标位置左侧最高柱子高度
            int[] rightHeight = new int[height.Length];//每一个下标位置右侧最高柱子高度
            int leftMax = 0;
            int rightMax = 0;
            int sum = 0;
            for (int i = 0; i < height.Length; i++)
            {
                leftMax = Math.Max(height[i], leftMax);//计算左边
                leftHeight[i] = leftMax;
                rightMax = Math.Max(height[height.Length - 1 - i], rightMax);//计算右边
                rightHeight[height.Length - 1 - i] = rightMax;
            }
            for (int j = 0; j < height.Length; j++)//便利所有柱子
            {
                if (height[j] < leftHeight[j] && height[j] < rightHeight[j])//形成水桶
                {
                    sum = sum + Math.Min(leftHeight[j], rightHeight[j]) - height[j];
                }
            }
            return sum;
        }
    }
}
