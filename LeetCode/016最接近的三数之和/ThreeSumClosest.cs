using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            int result = nums[0] + nums[1] + nums[2];//起始值
            if (result == target) 
            {
                return result;
            }
            nums = nums.OrderBy(n => n).ToArray();//进行排序
            int i, left, right; // 定义双指针
            for (i = 0; i < nums.Length; i++)
            {
                left = i + 1;
                right = nums.Length - 1;

                if (i > 0 && nums[i] == nums[i - 1]) //去重
                {
                    continue;
                }
                while (left < right)
                {
                    int sum = nums[i] + nums[left] + nums[right];//三数之和
                    if (sum == target)//和与目标值相同 
                    {
                        return sum;
                    }

                    int abs = Math.Abs(sum - target);//计算差值
                    if (abs < Math.Abs(result - target))
                    {
                        result = sum;
                    }
                   

                    if (sum > target)//结果过大，移动右指针
                    {
                        right--;
                    }
                    if (sum < target)//结果过小,移动左指针
                    {
                        left++;
                    }
                }
            }

            return result;
        }
    }
}
