using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int FirstMissingPositive(int[] nums)
        {
            int temp;
            int length = nums.Length;
            int result = length + 1;
            for (int i = 0; i < length; i++)
            {
                while (nums[i] > 0 && nums[i] <= length && nums[i]-1!= i)//判断是否需要放入桶中
                {
                    if (nums[i] == nums[nums[i] - 1])
                    {
                        nums[i] = 0;
                    }
                    else
                    {
                        temp = nums[nums[i] - 1];
                        nums[nums[i] - 1] = nums[i];
                        nums[i] = temp;
                    }

                }
            }
            for (int i = 0; i < length; i++)
            {
                if (nums[i]!=i+1) //判断桶里的数是否正确
                {
                    result = i + 1;
                    break;
                }
            }
            return result;
        }
    }
}
