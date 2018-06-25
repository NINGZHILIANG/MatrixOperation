using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    partial class Matrix
    {
        private int sizeRow;
        private int sizeColumn;
        public int[,] matrix;

        public Matrix (int column, int row)
        {
            sizeRow = row;
            sizeColumn = column;
        }
        public Matrix(int column,int row,int[,] mat)
        {
            matrix = mat;
            sizeRow = row;
            sizeColumn = column;
        }
    }
}
