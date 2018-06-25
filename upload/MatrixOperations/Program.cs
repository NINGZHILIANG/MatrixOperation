using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int row1 = 0;
            int row2 = 0;
            int column1 = 0;
            int column2=0;
            int integer = 1;

            Console.WriteLine("Please enter column1:");
            column1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter row1:");
            row1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter column2:");
            column2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter row2:");
            row2 = Convert.ToInt32(Console.ReadLine());

            Matrix m1 = new Matrix(column1, row1);
            Matrix m2 = new Matrix(column2, row2);

            Console.WriteLine("Please enter matrix1:");
            m1.InputMatrix();

            Console.WriteLine("Please enter matrix2:");
            m2.InputMatrix();

            (m1 + m2).PrintMatrix("matrix1+matrix2=");
            (m1 - m2).PrintMatrix("matrix1-maxtrix2=");

            integer = Convert.ToInt32(Console.ReadLine());
            (m1.MulAInteger(integer)).PrintMatrix("matrix1*({integer})=");
            (m2.MulAInteger(integer)).PrintMatrix("matrix2*({integer})=");

            (m1 * m2).PrintMatrix("Matrix1 multiplicate matrix2=");

            Console.WriteLine($"Matrix1 == Matrix2 : {m1 == m2}");
            Console.WriteLine($"Matrix != Matrix2 : {m1 != m2}");

            (m1.TensionMatrix()).PrintMatrix("Matrix transposite :");

            Console.ReadKey();
        }
    }
}
