using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)//主操作放在长的数组上可以减少大多数情况下的算法耗时
            { 
                int[] temp = nums1;
                nums1 = nums2;
                nums2 = temp;
            }
            int minI = 0;       //i 所处位置可能的最小值
            int maxI = nums1.Length;        //i 所处位置可能的最大值
            int halfLen = (nums1.Length + nums2.Length + 1) / 2;//i的一半长度 由于int计算小数部分会被完全舍去，所以+1之后再除可以适应奇偶问题
            while (minI <= maxI)
            {
                int i = (minI + maxI) / 2;  //在可能的范围内用二分查找法来找到正确的数值，这个是中间值
                int j = halfLen - i;        //找到nums2 放入numsLeft中的最大值的位置
                if (i < maxI && nums2[j - 1] > nums1[i]) //判断nums2 放入 numsLeft 中的最大值是否大于 nums1 放入numsRight 中的最小值
                {
                    minI = i + 1; // i 这个中间值小了，我们调整 i 的范围
                }
                else if (i > minI && nums1[i - 1] > nums2[j])//判断nums2 放入 numsRight 中的最小值是否小于 nums1 放入numsLeft 中的最大值
                {
                    maxI = i - 1; //  i 这个中间值大了，我们调整 i 的范围
                }
                else //i值是正确的值
                {
                    int maxLeft;
                    if (i == 0)
                    {
                        maxLeft = nums2[j - 1]; 
                    }
                    else if (j == 0) 
                    {
                        maxLeft = nums1[i - 1]; 
                    }
                    else 
                    {
                        maxLeft = Math.Max(nums1[i - 1], nums2[j - 1]); 
                    }
                    if ((nums1.Length + nums2.Length) % 2 == 1) 
                    { 
                        return maxLeft; 
                    }

                    int minRight = 0;
                    if (i == nums1.Length) 
                    {
                        minRight = nums2[j]; 
                    }
                    else if (j == nums2.Length) 
                    {
                        minRight = nums1[i]; 
                    }
                    else 
                    { 
                        minRight = Math.Min(nums2[j], nums1[i]); 
                    }

                    return (maxLeft + minRight) / 2.0;
                }
            }
            return 0.0;
        }

    }
}
