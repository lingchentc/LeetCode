using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public void Rotate(int[][] matrix)
        {
            int n = matrix.GetLength(0);//找出矩阵的宽度
            for (int i = 0; i < n / 2; i++)//旋转的起点只有一半（另一半的位置在其他选旋转中会被使用到）
            {
                for (int j = i; j < n - i - 1; j++)//y轴同理
                {
                    int temp = matrix[i][j];//反向覆盖可以减少利用temp的次数
                    matrix[i][j] = matrix[n - j - 1][i];
                    matrix[n - j - 1][i] = matrix[n - i - 1][n - j - 1];
                    matrix[n - i - 1][n - j - 1] = matrix[j][n - i - 1];
                    matrix[j][n - i - 1] = temp;
                }
            }
        }
    }
}
