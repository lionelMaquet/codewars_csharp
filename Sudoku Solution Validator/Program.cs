using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku_Solution_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static bool ValidateSolution(int[][] board)
        {

            // check each row for a duplicate
            foreach(int[] row in board)
            {
                if(row.Distinct().Count() != 9 || row.ToList().Contains(0))
                {
                    return false;
                }

            }

            // check each column for a duplicate
            for (int colIndex = 0; colIndex < board.ToList().Count; colIndex++)
            {
                List<int> column = new List<int>();
                foreach(int[] row in board)
                {
                    column.Add(row[colIndex]);
                }

                if (column.Distinct().Count() != 9 || column.ToList().Contains(0))
                {
                    return false;
                }

            }
            
            // ADD check of sub grids (3x3)
            for (int x = 0; x <= 2; x++)
            {
                for (int y = 0; y <= 2; y++)
                {
                    List<int> numbersPresent = new List<int>();

                    for (int i = 0; i <= 2; i++)
                    {
                        for (int j = 0; j <= 2; j++)
                        {
                            numbersPresent.Add(board[x * 3 + i][y * 3 + j]);
                        }
                    }

                    if (numbersPresent.Distinct().Count() != 9)
                    {
                        return false;
                    }

                    if (numbersPresent.Any(num => numbersPresent.Count(z => z == num) > 1 ))
                    {
                        return false;
                    }

                }
            }
            return true;
        }
    }
}
