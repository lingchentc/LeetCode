using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            // 记录行
            bool[,] row = new bool[9,9];
            // 记录列
            bool[,] col = new bool[9,9];
            // 记录九宫格
            bool[,] box = new bool[9,9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        int num = board[i][j] - '1';
                        int boxIndex = i / 3 * 3 + j / 3;
                        if (row[i,num] || col[j,num] || box[boxIndex,num])
                        {
                            return false;
                        }
                        else
                        {
                            row[i,num] = true;
                            col[j,num] = true;
                            box[boxIndex,num] = true;
                        }
                    }
                }
            }
            return true;
        }
    }
}
