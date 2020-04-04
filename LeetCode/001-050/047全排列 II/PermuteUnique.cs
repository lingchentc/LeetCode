using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums.Length == 0)
            {
                return result;
            }
            bool[] used = new bool[nums.Length];//用于记录哪些数字被使用过，这里记录数字所在数组的位置
            nums = nums.OrderBy(n => n).ToArray();//排序用于去重
            PermuteUnique(result, nums, new List<int>(), used);
            return result;
        }

        private void PermuteUnique(IList<IList<int>> result, int[] nums, List<int> list, bool[] used)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i - 1] == nums[i])//去重
                {
                    continue;
                }
                if (!used[i])
                {
                    List<int> path = new List<int>(list);
                    path.Add(nums[i]);
                    if (path.Count == nums.Length)
                    {
                        result.Add(path);
                    }
                    used[i] = true;//记录占位下用于后续路径验证
                    PermuteUnique(result, nums, path, used);
                    used[i] = false;//去掉占位用于下次循环
                }
            }
        }
    }
}
