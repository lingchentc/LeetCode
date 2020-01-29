using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int,int> numDic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var jValue = target - nums[i];
                if (numDic.ContainsKey(jValue) && jValue != nums[i])
                {
                    return new int[] { i, (int)numDic[jValue] };
                }
                numDic.Add(nums[i], i);
            }
            throw new Exception("No two sum solution");
        }
    }
}
