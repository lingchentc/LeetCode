using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public partial class Solution
    {
        bool[,] _rows = new bool[9, 9], _cols = new bool[9, 9], _box = new bool[9, 9];
        bool _finished = false;

        public void SolveSudoku(char[][] board)
        {
            for (int row = 0; row < 9; row++)//遍历数独，将使用过的数字的状态置为true
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row][col] != '.')
                    {
                        _rows[row, board[row][col] - '1'] = true;
                        _cols[col, board[row][col] - '1'] = true;
                        _box[row / 3 * 3 + col / 3, board[row][col] - '1'] = true;
                    }
                }
            }
            SolveSudoku(board, 0, 0);
        }
        private void SolveSudoku(char[][] board, int row, int col)
        {
            
            if (row == 9)//到9行，即已经解完
            {
                _finished = true;
                return;
            }
            if (board[row][col] != '.')
            {
                if (col == 8)
                {
                    SolveSudoku(board, row + 1, 0);
                }
                else
                {
                    SolveSudoku(board, row, col + 1);
                }

            }
            else
            {
                int box = row / 3 * 3 + col / 3;
                for (int i = 0; i < 9; i++)
                {
                   
                    if (!_rows[row, i] && !_cols[col, i] && !_box[box, i])//选择合规的数字填入
                    {
                        board[row][col] = (char)(i + '1');
                        _rows[row, i] = true;
                        _cols[col, i] = true;
                        _box[box, i] = true;
                       
                        if (col == 8)//到行尾，填写下一行
                        {
                            SolveSudoku(board, row + 1, 0);
                        }
                        else
                        {
                            SolveSudoku(board, row, col + 1);
                        }

                       
                        if (!_finished) //如果不能解出数独，回溯
                        {
                            board[row][col] = '.';
                            _rows[row, i] = false;
                            _cols[col, i] = false;
                            _box[box, i] = false;
                        }
                    }
                }
            }
        }
    }
}
