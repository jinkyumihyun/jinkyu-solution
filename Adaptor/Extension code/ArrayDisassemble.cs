using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adaptor.Ref_code
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Returns the row with number 'row' of this matrix as a 1D-Array.
        /// </summary>
        public static T[] GetRowVector<T>(this T[,] matrix, int row)
        {
            var rowNums = matrix.GetLength(0);           
            if (row >= rowNums)
            {
                throw new ArgumentException("ArrayExtension.GetRowVector: row >= rowNums ");
            }

            var rowLength = matrix.GetLength(1);
            var rowVector = new T[rowLength];

            for (var i = 0; i < rowLength; i++)
                rowVector[i] = matrix[row, i];

            return rowVector;
        }
        /// <summary>
        /// Sets the row with number 'row' of this 2D-matrix to the parameter 'rowVector'.
        /// </summary>
        public static void SetRowVector<T>(this T[,] matrix, int row, T[] rowVector)
        {
            var rowNums = matrix.GetLength(0);
            if (row >= rowNums)
            {
                throw new ArgumentException("ArrayExtension.SetRowVector: row >= rowNums ");
            }
            var rowLength = matrix.GetLength(1);
            var rowVectorLength = rowVector.GetLength(0);
            if (rowVectorLength <= rowLength)
            {
                throw new ArgumentException("ArrayExtension.SetRowVector: rowVectorLength <=  rowLength");
            }
            for (var i = 0; i < rowLength; i++)
                matrix[row, i] = rowVector[i];
        }

        /// <summary>
        /// Returns the column with number 'col' of this matrix as a 1D-Array.
        /// </summary>
        public static T[] GetColVector<T>(this T[,] matrix, int col)
        {
            var colLength = matrix.GetLength(0);
            var colVector = new T[colLength];
            //check col length
            for (var i = 0; i < colLength; i++)
                colVector[i] = matrix[i, col];

            return colVector;
        }
        /// <summary>
        /// Sets the column with number 'col' of this 2D-matrix to the parameter 'colVector'.
        /// </summary>
        public static void SetColVector<T>(this T[,] matrix, int col, T[] colVector)
        {
            var colLength = matrix.GetLength(0);
            //check col length
            for (var i = 0; i < colLength; i++)
                matrix[i, col] = colVector[i];
        }
    }
}

//    double[,] myMatrix = ... // Initialize with desired size and values.
//double[] myRowVector = myMatrix.GetRow(2); // Gets the third row.
//    double[] myColVector = myMatrix.GetCol(1); // Gets the second column.
//    myMatrix.SetCol(2, myColVector); // Sets the third column to the second c
//}
