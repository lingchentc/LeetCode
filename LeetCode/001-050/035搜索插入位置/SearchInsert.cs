using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            //特例
            if (nums[0] >= target) 
            {
                return 0;
            }
            if (nums[nums.Length - 1] == target) 
            {
                return nums.Length -1;
            }
            if (nums[nums.Length - 1] < target) 
            {
                return nums.Length;
            }
            int front = 0, end = nums.Length - 1;
           
            while (front < end) //找到目标
            {
                int mid = (front + end) / 2;
                if (nums[mid] > target)
                {
                    end = mid - 1;
                }
                else if (nums[mid] < target)
                {
                    front = mid + 1;
                }
                else
                {
                    return mid;
                }
            }
            if (nums[front] >= target) 
            {
                return front;
            }
            if (nums[front] < target) 
            {
                return front + 1;
            }
            return 0;
        }
    }
}
