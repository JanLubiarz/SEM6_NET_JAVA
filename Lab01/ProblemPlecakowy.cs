using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Lab01_UnitTests"), InternalsVisibleTo("Lab01_ProblemPlecakowyApp")]
namespace Lab01
{
    internal class ProblemPlecakowy
    {
        public List<Przedmiot> przedmioty;
        public int ilePrzedmiotow;
        public ProblemPlecakowy(int ilePrzedmiotow, int ziarno)
        {
            this.ilePrzedmiotow = ilePrzedmiotow;
            przedmioty = UtworzListePrzedmiotow(ziarno);
        }
        
        public List<Przedmiot> UtworzListePrzedmiotow(int ziarno)
        {
            List<Przedmiot> przedmioty = new List<Przedmiot>();
            Random random = new Random(ziarno);

            int waga;
            int wartosc;

            for (int i = 0; i < ilePrzedmiotow; i++)
            {
                waga = random.Next(1, 11);
                wartosc = random.Next(1, 11);
                przedmioty.Add(new Przedmiot(wartosc, waga, i));
            }

            return przedmioty;
        }

        public override string ToString()
        {
            StringBuilder wypisz = new StringBuilder();
            for (int i = 0; i < ilePrzedmiotow; i++)
            {
                wypisz.AppendLine($"no. {i} v: {przedmioty[i].wartosc} w: {przedmioty[i].waga}");
            }

            return wypisz.ToString();
        }

        public int PorownanieStosunku(Przedmiot pierwszy, Przedmiot drugi)
        {
            int stosunek = 0;
            float stosunekPierwszego = (float)pierwszy.wartosc / pierwszy.waga;
            float stosunekDrugiego = (float)drugi.wartosc / drugi.waga;
            
            //Console.WriteLine(stosunekPierwszego);
            //Console.WriteLine(stosunekDrugiego);
            
            if (stosunekPierwszego > stosunekDrugiego)
                stosunek = -1;
            else if (stosunekDrugiego > stosunekPierwszego)
                stosunek = 1;
            else
                stosunek = 0;
            
            return stosunek;
        }

        public Result Solve(int pojemnosc)
        {
            int wartoscSum = 0;
            int wagaSum = 0;
            List<int> numerySpakowanychPrzedmiotow = new List<int>();

            przedmioty.Sort(PorownanieStosunku);

            foreach (Przedmiot przedmiot in przedmioty) 
            {
                if (wagaSum + przedmiot.waga <= pojemnosc)
                {
                    numerySpakowanychPrzedmiotow.Add(przedmiot.id);
                    wartoscSum += przedmiot.wartosc;
                    wagaSum += przedmiot.waga;
                }
            }

            Result wynik = new Result(numerySpakowanychPrzedmiotow, wagaSum, wartoscSum);
            return wynik;
        }

    }
}
