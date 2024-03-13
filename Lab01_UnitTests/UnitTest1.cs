using Lab01;

namespace Lab01_UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod_1_Licz_Elementy()
        {
            List<int> wartosci = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (int n in wartosci)
            {
                ProblemPlecakowy problem = new ProblemPlecakowy(n, 1);
                Assert.AreEqual(n, problem.przedmioty.Count);
            }
        }

        [TestMethod]
        public void TestMethod_2_Plecak_Zerowa_Pojemnosc()
        {
            int ziarno = 1;
            int iloscPrzedmiotow = 5;
            ProblemPlecakowy problemPlecakowy = new ProblemPlecakowy(iloscPrzedmiotow, ziarno);
            int pojemnosc = 0;

            Result wynik = problemPlecakowy.Solve(pojemnosc);

            Assert.AreEqual(0, wynik.listaNumerowPrzedmiotow.Count);
            Assert.AreEqual(0, wynik.wagaSum);
            Assert.AreEqual(0, wynik.wartoscSum);
        }

        [TestMethod]
        public void TestMethod_3_Brak_Elementow()
        {
            int ziarno = 1;
            int iloscPrzedmiotow = 0;
            ProblemPlecakowy problemPlecakowy = new ProblemPlecakowy(iloscPrzedmiotow, ziarno);
            int pojemnosc = 5;

            Result wynik = problemPlecakowy.Solve(pojemnosc);

            Assert.AreEqual(0, wynik.listaNumerowPrzedmiotow.Count);
            Assert.AreEqual(0, wynik.wagaSum);
            Assert.AreEqual(0, wynik.wartoscSum);
        }

        [TestMethod]
        public void TestMethod_4_Sprawdzenie_Wynikow_Dla_Konkretnej_Instancji()
        {
            int pojemnosc = 20;
            int ziarno = 1;
            int iloscPrzedmiotow = 5;

            ProblemPlecakowy problemPlecakowy = new ProblemPlecakowy(iloscPrzedmiotow, ziarno);

            Result oczekiwanyWynik = new Result(new List<int> { 4, 3, 1, 2 }, 18, 30);
            Result wynik = problemPlecakowy.Solve(pojemnosc);

            Console.WriteLine(oczekiwanyWynik);
            Console.WriteLine("----------");
            Console.WriteLine(wynik);

            CollectionAssert.AreEqual(oczekiwanyWynik.listaNumerowPrzedmiotow, wynik.listaNumerowPrzedmiotow);
            Assert.AreEqual(oczekiwanyWynik.wagaSum, wynik.wagaSum);
            Assert.AreEqual(oczekiwanyWynik.wartoscSum, wynik.wartoscSum);
        }

        [TestMethod]
        public void TestMethod_5_Sprawdzenie_Czy_Kolejnosc_Przedmiotow_Wplywa_Na_Wynik()
        {
            int pojemnosc = 20;
            int ziarno = 1;
            int iloscPrzedmiotow = 5;

            ProblemPlecakowy problemPlecakowy = new ProblemPlecakowy(iloscPrzedmiotow, ziarno);

            problemPlecakowy.przedmioty.Reverse();

            Result oczekiwanyWynik = new Result(new List<int> { 4, 3, 1, 2 }, 18, 30);
            Result wynik = problemPlecakowy.Solve(pojemnosc);

            Console.WriteLine(oczekiwanyWynik);
            Console.WriteLine("----------");
            Console.WriteLine(wynik);

            CollectionAssert.AreEqual(oczekiwanyWynik.listaNumerowPrzedmiotow, wynik.listaNumerowPrzedmiotow);
            Assert.AreEqual(oczekiwanyWynik.wagaSum, wynik.wagaSum);
            Assert.AreEqual(oczekiwanyWynik.wartoscSum, wynik.wartoscSum);
        }

        [TestMethod]
        public void TestMethod_6_Sprawdzenie_Poprawnosci_Funkcji_PorownaniaStosunku_Dla_Roznych_Obiektow()
        {
            Przedmiot pierwszy = new Przedmiot(4, 2, 0);
            Przedmiot drugi = new Przedmiot(2, 2, 1);
            ProblemPlecakowy problemPlecakowy = new ProblemPlecakowy(0, 1);

            int wynik = problemPlecakowy.PorownanieStosunku(pierwszy, drugi);

            Console.WriteLine("Powinno wyjsc -1, bo stosunek pierwszego obiektu jest wiekszy");
            Console.WriteLine("----------");
            Console.WriteLine(wynik);
            Assert.AreEqual(-1, wynik);
        }

        [TestMethod]
        public void TestMethod_7_Tylko_Jeden_Przedmiot_Spelnia_Ograniczenia()
        {
            Przedmiot pierwszy = new Przedmiot(100, 8, 0);
            Przedmiot drugi = new Przedmiot(3, 2, 1);
            Przedmiot trzeci = new Przedmiot(2, 2, 2);
            Przedmiot[] przedmiociki = { pierwszy, drugi, trzeci };
            ProblemPlecakowy problemPlecakowy = new ProblemPlecakowy(3, 1);
            int pojemnosc = 8;


            for (int i = 0; i < problemPlecakowy.przedmioty.Count; i++)
            {
                problemPlecakowy.przedmioty[i] = przedmiociki[i];
            }
            Console.WriteLine("Przedmioty uzyte do testu: ");
            Console.WriteLine(problemPlecakowy);

            Result oczekiwanyWynik = new Result(new List<int> { 0 }, 8, 100);
            Result wynik = problemPlecakowy.Solve(pojemnosc);

            Console.WriteLine(oczekiwanyWynik);
            Console.WriteLine("----------");
            Console.WriteLine(wynik);

            CollectionAssert.AreEqual(oczekiwanyWynik.listaNumerowPrzedmiotow, wynik.listaNumerowPrzedmiotow);
            Assert.AreEqual(oczekiwanyWynik.wagaSum, wynik.wagaSum);
            Assert.AreEqual(oczekiwanyWynik.wartoscSum, wynik.wartoscSum);
        }

        [TestMethod]
        public void TestMethod_8_Sprawdzenie_Poprawnosci_Funkcji_PorownaniaStosunku_Dla_Identycznych_Obiektow()
        {
            Przedmiot pierwszy = new Przedmiot(2, 2, 0);
            Przedmiot drugi = new Przedmiot(2, 2, 1);
            ProblemPlecakowy problemPlecakowy = new ProblemPlecakowy(0, 1);

            int wynik = problemPlecakowy.PorownanieStosunku(pierwszy, drugi);

            Console.WriteLine("Powinno wyjsc 0, bo obiekty sa identyczne");
            Console.WriteLine("----------");
            Console.WriteLine(wynik);
            Assert.AreEqual(0, wynik);
        }
    }
}