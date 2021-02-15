using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku_Solution_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static bool ValidateSolution(int[][] board)
        {
            foreach(int[] row in board)
            {
                if (row.ToList().Any(rowValue => row.Count(y => y == rowValue ) > 1 || rowValue == 0)){
                    return false;
                }
            }

            for (int colIndex = 0; colIndex < board.ToList().Count; colIndex++)
            {
                List<int> column = new List<int>();
                foreach(int[] row in board)
                {
                    column.Add(row[colIndex]);
                }

                if (column.Any(colValue => column.Count(y => y == colValue) > 1 || colValue == 0))
                {
                    return false;
                }
            }

            // TODO
            // ADD check of sub grids (3x3)

            return true;
        }
    }
}
