using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums == null)//空数组返回0
            {
                return 0;
            }
            if (nums.Length <= 1)//数组长度小于等于1 返回数组长度（0和1长度的数组都不会有重复项目）
            {
                return nums.Length;
            }
            int j = 0;
            for (int i = 1; i < nums.Length; i++)//指针i用于遍历数组
            {
                if (nums[i] != nums[j])
                {
                    j++;//指针j，用于记录位置
                    nums[j] = nums[i];
                }
            }
            return j + 1;//数组的长度为j+1
        }
    }
}
