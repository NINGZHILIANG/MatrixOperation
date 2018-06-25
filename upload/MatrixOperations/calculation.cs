using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    partial class Matrix
    {
        //Addition of two matrixes
        public static Matrix operator + (Matrix m1,Matrix m2)
        {
            Matrix result = new Matrix(m1.sizeRow, m1.sizeColumn);
            try
            {
                m1.CompareSize(m2);
                for (int i = 0; i < m1.sizeRow; i++)
                    for (int j = 0; j < m1.sizeColumn; j++)
                        result.matrix[i, j] = m1.matrix[i, j] + m2.matrix[i, j];
            }
            catch (Exception mException)
            {
                Console.WriteLine($"matrix 1 ({m1.sizeRow},{m1.sizeColumn }) is not the same size to matrix 2 ({m2.sizeRow},{m2.sizeColumn }) !");
            }
            return result;
        }

        // Substraction of two matrixes
        public static Matrix operator - (Matrix m1,Matrix m2)
        {
            Matrix result = new Matrix(m1.sizeRow, m1.sizeColumn);
            try
            {
                m1.CompareSize(m2);
                for (int i = 0; i < m1.sizeRow; i++)
                    for (int j = 0; j < m1.sizeColumn ; j++)
                        result.matrix[i, j] = m1.matrix[i, j] - m2.matrix[i, j];
            }
            catch (Exception mException)
            {
                Console.WriteLine($"matrix 1 ({m1.sizeRow},{m1.sizeColumn }) is not the same size to matrix 2 ({m2.sizeRow},{m2.sizeColumn }) !");
            }
            return result;
        }

        // Get new matrix which is multipled on the decimal number
        public Matrix MulAInteger(int integer)
        {
            Matrix result = new Matrix(sizeRow, sizeColumn);
            for (int i = 0; i < sizeRow; i++)
                for (int j = 0; j < sizeColumn; j++)
                    result.matrix[i, j] = matrix[i, j]*integer ;
            return result;
        }

        // Multiplication of the matrixes
        public static Matrix operator * (Matrix m1,Matrix m2)
        {
            Matrix result = new Matrix(m1.sizeRow, m1.sizeColumn);
            try
            {
                for (int i = 0; i < m1.sizeRow; i++)
                    for (int j = 0; j < m2.sizeColumn; j++)
                        for(int k=0;k<m1.sizeRow;k++)
                            result.matrix[i, j] += m1.matrix[i, k] * m2.matrix[k, j];
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range exception!");
            }
            return result;
        }

        // Verification of the matrixes
        public static bool operator == (Matrix m1, Matrix m2)
        {
            if (!m1.CompareSizeToMultiplication(m2))
                return false;
            for (int i = 0; i < m1.sizeColumn; i++)
                for (int j = 0; j < m1.sizeRow; j++)
                    if (m1.matrix[i, j] != m2.matrix[i, j])
                        return false;
            return true;
        }
        public static bool operator !=(Matrix m1, Matrix m2)
        {
            if (m1.CompareSizeToMultiplication(m2))
                return true;
            bool flag = false;
            for (int i = 0; i < m1.sizeColumn; i++)
                for (int j = 0; j < m1.sizeRow; j++)
                    if (m1.matrix[i, j] != m2.matrix[i, j])
                        flag = true;
            return flag;
        }

        // matrix transposition
        public Matrix TensionMatrix()
        {
            Matrix result = new Matrix(sizeColumn , sizeRow );
            try
            {
                for (var i = 0; i < sizeColumn; i++)
                    for (var j = 0; j < sizeRow; j++)
                    {
                        result.matrix[i, j] = matrix[j, i];
                    }
            }
            catch (IndexOutOfRangeException)
            {
                Console.Write("Index out of range");
            }
            return result;
        }

        public void InputMatrix()
        {
            for (int i = 0; i < sizeRow  ; i++)
                for (int j = 0; j < sizeColumn  ; j++)
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintMatrix(string typePrint)
        {
            Console.WriteLine(typePrint);
            for (int i = 0; i < sizeRow; i++)
                for (int j = 0; j < sizeColumn; j++)
                    Console.Write(matrix[i, j] + " ");
            Console.WriteLine();
        }
        
        public bool CompareSizeToMultiplication(Matrix m)
        {
            if (sizeRow == m.sizeRow)
                return true;
            Console.WriteLine($"Matrix A can not be multiplide on Matrix B!");
            return false;
        }

        // Verification of the sizes of the matrixes
        public bool CompareSize(Matrix m)
        {
            if (sizeRow != m.sizeRow || sizeColumn != m.sizeColumn)
                throw new Exception("mException");
            return true;
        }
    }
}
