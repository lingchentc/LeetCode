using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int Search(int[] nums, int target)
        {
            if (nums.Length == 0) 
            {
                return -1;
            }
            int front = 0, end = nums.Length - 1;
            while (front < end)
            {
                int mid = (front + end) / 2;
                if (nums[mid] == target) 
                {
                    return mid;
                }
                if (nums[front] == target)
                {
                    return front;
                }
                if (nums[end] == target)
                {
                    return end;
                }
                if (nums[front] <= nums[mid] && nums[front] <= target && target <= nums[mid])
                {
                    end = mid - 1;
                    
                }
                else if (nums[mid] < nums[front] && target <= nums[mid] && nums[mid] < nums[front])
                {
                    end = mid - 1;
                }
                else if (nums[mid] < nums[front]&& nums[mid] < nums[front] && nums[front] <= target) 
                {
                    end = mid - 1;
                }
                else
                {
                    front = mid + 1;
                }
                    
            }
            return front == end && nums[front] == target ? front : -1;

           
        }
    }
}
