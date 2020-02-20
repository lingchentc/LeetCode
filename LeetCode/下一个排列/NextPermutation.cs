using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public void NextPermutation(int[] nums)
        {
            int i = nums.Length - 1;//第一次循环指针。
            while (i > 0 && nums[i ] <= nums[i-1])
            {
                i--;
            }
            if (i > 0)
            {
                int j = nums.Length - 1;//第二次循环指针
                while (j >= 0 && nums[j] <= nums[i-1])
                {
                    j--;
                }
                int temp = nums[i-1];
                nums[i-1] = nums[j];
                nums[j] = temp;
            }
            int start = i, end = nums.Length - 1;
            while (start < end)//倒序循环
            {
                int temp2 = nums[start];
                nums[start] = nums[end];
                nums[end] = temp2;
                start++;
                end--;
            }
        }
    }
       
}
