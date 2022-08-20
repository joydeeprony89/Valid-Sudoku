using System;
using System.Collections.Generic;

namespace Valid_Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
             [["8","3",".",".","7",".",".",".","."]
            ,["6",".",".","1","9","5",".",".","."]
            ,[".","9","8",".",".",".",".","6","."]
            ,["8",".",".",".","6",".",".",".","3"]
            ,["4",".",".","8",".","3",".",".","1"]
            ,["7",".",".",".","2",".",".",".","6"]
            ,[".","6",".",".",".",".","2","8","."]
            ,[".",".",".","4","1","9",".",".","5"]
            ,[".",".",".",".","8",".",".","7","9"]]
             
             */
        }
    }

    public class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            var set = new HashSet<string>();
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    var number = board[i][j];
                    if (number == '.') continue;
                    string rStr = $"{number} in row {i}";
                    string cStr = $"{number} in column {j}";
                    string bStr = $"{number} in block {i / 3} row and 1{j / 3} column";
                    if (!set.Add(rStr) ||
                        !set.Add(cStr) ||
                        !set.Add(bStr))
                        return false;
                }
            }
            return true;
        }
    }
}
