using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            nums = nums.OrderBy(n => n).ToArray();//进行排序
            int i, left, right; // 定义双指针
            for (i = 0; i < nums.Length - 3; i++)//后边有3个数
            {

                if (nums[i] + nums[i + 1] + nums[i + 2] + nums[i + 3] > target)//计算nums[i]时的组合最小值，如果大于target，则不需要继续计算 
                {
                    break;
                }
                if (nums[i] + nums[nums.Length - 1] + nums[nums.Length - 2] + nums[nums.Length - 3] < target)//计算nums[i]时的组合最大值，如果小于target，则不需要继续计算 
                {
                    continue;
                }
                if (i > 0 && nums[i] == nums[i - 1]) //去重
                {
                    continue;
                }

                for (int j = i + 1; j < nums.Length - 2; j++)//后边有两个数
                {

                    if (nums[i] + nums[j] + nums[j + 1] + nums[j + 2] > target)//计算nums[i],nums[j]时的组合最小值，如果大于target，则不需要继续计算 
                    {
                        break;
                    }
                    if (nums[i] + nums[nums.Length - 1] + nums[nums.Length - 2] + nums[j] < target)//计算nums[i],nums[j]时的组合最大值，如果小于target，则不需要继续计算 
                    {
                        continue;
                    }
                    if (j > i + 1 && nums[j] == nums[j - 1]) //去重
                    {
                        continue;
                    }
                    left = j + 1;
                    right = nums.Length - 1;
                    while (left < right)
                    {
                        if (nums[i] + nums[j] + nums[left] + nums[right] == target)
                        {
                            result.Add(new List<int> { nums[i], nums[j], nums[left], nums[right] });
                            while (left < right && nums[left] == nums[left + 1])//左去重移动
                            {
                                left++;
                            }
                            while (left < right && nums[right] == nums[right - 1])//右去重移动
                            {
                                right--;
                            }
                            left++;//两边同时移动
                            right--;
                            continue;
                        }
                        if (nums[i] + nums[j] + nums[left] + nums[right] > target)//结果过大，移动右指针
                        {
                            right--;
                        }
                        if (nums[i] + nums[j] + nums[left] + nums[right] < target)//结果过小,移动左指针
                        {
                            left++;
                        }
                    }
                }


            }

            return result;
        }
    }
}
