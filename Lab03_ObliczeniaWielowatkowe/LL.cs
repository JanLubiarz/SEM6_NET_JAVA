using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_ObliczeniaWielowatkowe
{
    internal class ThreadArguments
    {
        public Matrix Matrix1 { get; set; }
        public Matrix Matrix2 { get; set; }
        public Matrix ResultMatrix { get; set; }
        public int StartRow { get; set; }
        public int EndRow { get; set; }
    }


    internal class LL
    {
        int numOfThreads;
        public static readonly object locker = new object();

        public Matrix CreateThreads(Matrix mx1, Matrix mx2, int numOfThreads)
        {
            this.numOfThreads = numOfThreads;
            int dimension = mx1.dimension;
            Matrix resultMatrix = new Matrix();
            resultMatrix.createResultMatrix(dimension);

            Thread[] threads = new Thread[numOfThreads];
            int chunkSize = dimension / numOfThreads;
            for (int i = 0; i < numOfThreads; i++)
            {
                int startRow = i * chunkSize;
                int endRow;
                if (i == numOfThreads - 1) endRow = dimension;    
                else endRow = (i + 1) * chunkSize;
                threads[i] = new Thread(new ParameterizedThreadStart(Calculate));
                threads[i].Start(new ThreadArguments { Matrix1 = mx1, Matrix2 = mx2, ResultMatrix = resultMatrix, StartRow = startRow, EndRow = endRow });
            }

            foreach (Thread x in threads)
                x.Join();

            return resultMatrix;
        }

        // kazdy watek wybiera swoj wiersz i oblicza metoda: wybrany wiersz * kazda kolumna po kolei = wybrany wiersz w macierzy wynikowej
        public void Calculate(object obj)
        {
            ThreadArguments args = (ThreadArguments)obj;
            Matrix matrix1 = args.Matrix1;
            Matrix matrix2 = args.Matrix2;
            Matrix resultMatrix = args.ResultMatrix;
            int startRow = args.StartRow;
            int endRow = args.EndRow;
            int dimension = matrix1.dimension;

            for (int row = startRow; row < endRow; row++)
            {
                for (int col = 0; col < dimension; col++)
                {
                    // Obliczenia mnozenia konkretny wiersz razy kolumna
                    int sum = 0;
                    for (int k = 0; k < dimension; k++)
                    {
                        sum += matrix1.dynamicList[row][k] * matrix2.dynamicList[k][col];
                    }
                    // Synchronizacja lockerowa zeby przypadkiem nie nadpisac tego samego przez rozne watki
                    lock (locker)
                    {
                        resultMatrix.dynamicList[row][col] = sum;
                    }
                }
            }
        }

    public Matrix Multiply(Matrix mx1, Matrix mx2)
        {
            if (mx1.dimension != mx2.dimension)
            {
                throw new ArgumentException("Macierze muszą mieć takie same wymiary");
            }

            int dimension = mx1.dimension;
            Matrix resultMatrix = new Matrix();
            resultMatrix.createResultMatrix(dimension);

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < dimension; k++)
                    {
                        sum += mx1.dynamicList[i][k] * mx2.dynamicList[k][j];
                    }
                    resultMatrix.dynamicList[i][j] = sum;
                }
            }

            return resultMatrix;
        }
    }

}
