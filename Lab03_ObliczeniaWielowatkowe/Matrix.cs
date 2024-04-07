using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_ObliczeniaWielowatkowe
{
    internal class Matrix
    {
        public int dimension;
        public List<List<int>> dynamicList = new List<List<int>>();

        public void createMatrix(int dimension, int seed)
        {
            this.dimension = dimension;
            Random random = new Random(seed);

            // Tworzenie macierzy
            for (int i = 0; i < dimension; i++)
            {
                dynamicList.Add(new List<int>()); // Dodawanie wierszy do listy
                for (int j = 0; j < dimension; j++) 
                {
                    int num = random.Next(1,10);
                    dynamicList[i].Add(num); // Dodawanie elementow do wierszy
                }
            }       
        }
        public void createResultMatrix(int dimension)
        {
            this.dimension = dimension;
            // Tworzenie macierzy
            for (int i = 0; i < dimension; i++)
            {
                dynamicList.Add(new List<int>()); // Dodawanie wierszy do listy
                for (int j = 0; j < dimension; j++)
                {
                    dynamicList[i].Add(0); // Dodawanie elementow do wierszy
                }
            }
        }

        public override string ToString()
        {
            StringBuilder wypisz = new StringBuilder();
            for (int i = 0; i < dimension; i++)
            {
                wypisz.Append($"[ ");
                for (int j = 0; j < dimension; j++)
                {
                    wypisz.Append($" {dynamicList[i][j]} ");
                    if (j == dimension - 1)
                    {
                        wypisz.AppendLine($" ]");
                    }
                }
            }
            return wypisz.ToString();
        }

    }
}
