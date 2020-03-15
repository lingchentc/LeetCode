using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int Jump(int[] nums)
        {
            if (nums.Length == 1) //只有个长，则不需要跳即结束
            {
                return 0;
            }
            int current = 0;
            int step = 0;
            while (current+nums[current] < nums.Length-1) //如果本次跳最大值就可跳出，就不需要计算
            {
                int max = 0;
                int jump = 0;
                for (int i = 1; i <= nums[current]; i++)
                {
                    if (nums[current + i] + i > max) //找出选择相应走法后续能走的最远的一步
                    {
                        max = nums[current + i] + i;
                        jump = i;
                    }
                    
                }
                current += jump;
                step++;
            }
            step++;//再跳一次
            return step;
        }
    }
}
