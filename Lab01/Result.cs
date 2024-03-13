using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Result
    {
        public List<int> listaNumerowPrzedmiotow;
        public int wagaSum;
        public int wartoscSum;

        public Result(List<int> listaNumerowPrzedmiotow, int wagaSum, int wartoscSum)
        {
            this.listaNumerowPrzedmiotow = listaNumerowPrzedmiotow;
            this.wagaSum = wagaSum;
            this.wartoscSum = wartoscSum;
        }

        public override string ToString()
        {
            StringBuilder wynik = new StringBuilder();
            wynik.Append("Numery Przedmiotów: ");
            for (int i = 0; i < listaNumerowPrzedmiotow.Count; i++)
            {
                wynik.Append(listaNumerowPrzedmiotow[i] + " ");    
            }
            wynik.Append(Environment.NewLine);
            wynik.Append("Max wartosc: " + wartoscSum);
            wynik.Append(Environment.NewLine);
            wynik.Append("Max waga: " + wagaSum);
            return wynik.ToString();
        }
    }
}
