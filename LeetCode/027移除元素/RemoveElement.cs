using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {

        public int RemoveElement(int[] nums, int val)
        {
            if (nums == null)//空数组返回0
            {
                return 0;
            }
            int i = 0;//用于遍历数组的指针
            int n = nums.Length;//队尾的指针
            while (i < n)
            {
                if (nums[i] == val)
                {
                    nums[i] = nums[n - 1];//将队尾的值放入需要删除的值的位置
                    n--;//队尾指针向前移动一位
                }
                else
                {
                    i++;
                }
            }
            return n;
        }


        //public int RemoveElement(int[] nums, int val)
        //{
        //    if (nums == null)//空数组返回0
        //    {
        //        return 0;
        //    }
            
        //    int j = 0;
        //    for (int i = 0; i < nums.Length; i++)//指针i用于遍历数组
        //    {

        //        if (nums[i] != val)
        //        {
        //            nums[j] = nums[i];//写入元素
        //            j++;//指针j，用于记录位置
        //        }
                
        //    }
        //    return j + 1;//数组的长度为j+1
        //}
    }
}
