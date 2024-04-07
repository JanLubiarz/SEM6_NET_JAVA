using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab03_ObliczeniaWielowatkowe
{
    internal class HL
    {
        int numOfThreads;

        public Matrix MultiplyWithLimitation(Matrix mx1, Matrix mx2, int numOfThreads)
        {
            if (mx1.dimension != mx2.dimension)
            {
                throw new ArgumentException("Macierze musza miec takie same wymiary");
            }

            this.numOfThreads = numOfThreads;
            int maxThreads = numOfThreads;
            ParallelOptions opt = new ParallelOptions() { MaxDegreeOfParallelism = maxThreads };
            int dimension = mx1.dimension;
            Matrix resultMatrix = new Matrix();
            resultMatrix.createResultMatrix(dimension);

            Parallel.For( 0, dimension, opt, i =>
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
            });

            return resultMatrix;
        }
        public Matrix MultiplyWithoutLimitation(Matrix mx1, Matrix mx2)
        {
            if (mx1.dimension != mx2.dimension)
            {
                throw new ArgumentException("Macierze musza miec takie same wymiary");
            }

            int dimension = mx1.dimension;
            Matrix resultMatrix = new Matrix();
            resultMatrix.createResultMatrix(dimension);

            Parallel.For(0, dimension, i =>
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
            });

            return resultMatrix;
        }
    }

}
