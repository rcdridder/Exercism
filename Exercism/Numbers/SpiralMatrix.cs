using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercism.Numbers
{
    public static class SpiralMatrix
    {
        public static int[,] GetMatrix(int size)
        {
            int[,] matrix = new int[size, size];
            int rowStart = 0, rowEnd = size - 1, colStart = 0, colEnd = size - 1;
            RecursiveMatrix(matrix, 1, rowStart, rowEnd, colStart, colEnd);
            return matrix;
        }

        private static void RecursiveMatrix(int[,] matrix, int number, int rowStart, int rowEnd, int colStart, int colEnd)
        {
            if (rowStart > rowEnd || colStart > colEnd)
                return;
            for(int i = colStart; i <= colEnd; i++)
            {
                matrix[rowStart, i] = number;
                number++;
            }
            for (int i = rowStart + 1; i <= rowEnd; i++)
            {
                matrix[i, colEnd] = number;
                number++;
            }
            if(rowEnd != rowStart)
            {
                for(int i = colEnd - 1; i >= colStart; i--)
                {
                    matrix[rowEnd, i] = number;
                    number++;
                }
            }
            if (colEnd != colStart)
            {
                for(int i = rowEnd - 1; i >= rowStart + 1; i--)
                {
                    matrix[i, colStart] = number;
                    number++;
                }
            }
            RecursiveMatrix(matrix, number, rowStart + 1, rowEnd - 1, colStart + 1, rowEnd - 1);
        }
    }
}
