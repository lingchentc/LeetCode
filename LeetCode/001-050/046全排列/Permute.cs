using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums.Length == 0)
            {
                return result;
            }
            bool[] used = new bool[nums.Length];//用于记录哪些数字被使用过，这里记录数字所在数组的位置

            Permute(result, nums, new List<int>(), used);
            return result;
        }

        private void Permute(IList<IList<int>> result, int[] nums, List<int> list, bool[] used)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (!used[i]) 
                {
                    List<int> path = new List<int>(list);
                    path.Add(nums[i]);
                    if (path.Count == nums.Length) 
                    {
                        result.Add(path);
                    }
                    used[i] = true;//记录占位下用于后续路径验证
                    Permute(result, nums, path, used);
                    used[i] = false;//去掉占位用于下次循环
                }
            }
        }
    }
}
