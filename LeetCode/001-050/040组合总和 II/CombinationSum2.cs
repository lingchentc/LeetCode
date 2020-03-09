using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
            candidates = candidates.OrderBy(n => n).ToArray();//排序为了好排除相同值
            CombinationSum2(candidates, target, result, new List<int>(), 0, 0);//从根出发
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="candidates">给定的数组</param>
        /// <param name="target">目标值</param>
        /// <param name="result">结果集合</param>
        /// <param name="current">现在选择数字的集合</param>
        /// <param name="currentSum">现在数字的和</param>
        /// <param name="index">开始取值的位置</param>
        /// <returns></returns>
        private void CombinationSum2(int[] candidates, int target, IList<IList<int>> result, List<int> current, int currentSum, int index)
        {
            for (int i = index; i < candidates.Length; i++)
            {
                if (i>index && candidates[i] == candidates[i - 1]) //同层相等数字略过
                {
                    continue;
                }
                int value = currentSum + candidates[i];
                if (value < target) //值小于目标值，继续
                {
                    List<int> newList = new List<int>(current);
                    newList.Add(candidates[i]);
                    CombinationSum2(candidates, target, result, newList, value, i+1);
                }
                else if (value > target)//值大于目标值因为排过序，跳出即可
                {
                    break;
                }
                else //值等于目标值，添加结果
                {
                    List<int> newList = new List<int>(current);
                    newList.Add(candidates[i]);
                    result.Add(newList);
                }
            }
        }
    }
}
