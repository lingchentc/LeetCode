using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            nums = nums.OrderBy(n => n).ToArray();//进行排序
            int i, left, right; // 定义双指针
            for (i = 0; i < nums.Length; i++)
            {
                left = i + 1;
                right = nums.Length - 1;
                if (nums[i] > 0)
                {
                    break;
                }
                if (i > 0 && nums[i] == nums[i - 1]) //去重
                {
                    continue;
                }
                while (left < right) 
                {
                    if (nums[i] + nums[left] + nums[right] == 0)
                    {
                        result.Add(new List<int> { nums[i], nums[left], nums[right] });
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
                    if (nums[i] + nums[left] + nums[right] > 0)//结果过大，移动右指针
                    {
                        right--;
                    }
                    if (nums[i] + nums[left] + nums[right] < 0)//结果过小,移动左指针
                    {
                        left++;
                    }
                }
            }

            return result;
        }
    }
}
