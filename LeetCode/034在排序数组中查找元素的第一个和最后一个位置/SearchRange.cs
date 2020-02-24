using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            if (nums.Length == 0) 
            {
                return new int[] { -1, -1 };
            }
            if (nums.Length == 1 && nums[0] == target) 
            {
                return new int[] { 0, 0 };
            }
            if (nums.Length == 1 && nums[0] != target) 
            {
                return new int[] { -1, -1 };
            }
            int front = 0, end = nums.Length - 1;
            int targetIndex = -1;
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
                    targetIndex = mid;
                    break;
                }
            }
            if (nums[front] == target) 
            {
                targetIndex = front;
            }
            if (targetIndex == -1) 
            {
                return new int[] { -1, -1 };
            }
            front = 0;
            end = targetIndex;

            while (front < end) //从前半部分找到最左侧值
            {
                int mid = (front + end) / 2;
                if (nums[mid] != target)
                {
                    front = mid + 1;
                }
                else
                {
                    end = mid;
                }
                
            }
            int left = front;

            front = targetIndex;
            end = nums.Length - 1;

            while (front < end) //从后半部分找到最右侧值
            {
                int mid = (front + end) / 2;
                if (nums[mid] != target)
                {
                    end = mid;
                }
                else
                {
                    front = mid + 1;
                }
            }

            int right = nums[front]== target ? front : front - 1;
            
            return new int[] {left,right };
        }
    }
}
