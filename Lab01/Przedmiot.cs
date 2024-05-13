using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    internal class Przedmiot
    {
        public int wartosc { get; set; }
        public int waga { get; set; }
        public int id { get; set; }

        public Przedmiot(int wartosc, int waga, int id)
        {
            this.wartosc = wartosc;
            this.waga = waga;
            this.id = id;
        }

    }
}
