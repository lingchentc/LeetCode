using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();

            CombinationSum(candidates, target, result, new List<int>(), 0,0);//从根出发
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
        private void CombinationSum(int[] candidates, int target, IList<IList<int>> result,List<int> current, int currentSum,int index)
        {
            for (int i = index; i < candidates.Length; i++)
            {
                int value = currentSum + candidates[i];
                if (value < target) //值小于目标值，继续
                {
                    List<int> newList = new List<int>(current);
                    newList.Add(candidates[i]);
                    CombinationSum(candidates, target, result, newList, value, i);
                }
                else if (value > target)//值大于目标值，略过
                {
                    continue;
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
