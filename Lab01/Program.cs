namespace Lab01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ziarno;
            bool parsed = false;
            do
            {
                Console.WriteLine("Wprowadz ziarno: ");
                parsed = int.TryParse(Console.ReadLine(), out ziarno);
                if (!parsed)
                {
                    Console.WriteLine("Blad... Podaj liczbe calkowita");
                }
            } while (!parsed);

            int iloscPrzedmiotow;
            parsed = false;
            do
            {
                Console.WriteLine("Wprowadz ilosc przedmiotow: ");
                parsed = int.TryParse(Console.ReadLine(), out iloscPrzedmiotow);
                if (!parsed)
                {
                    Console.WriteLine("Blad... Podaj liczbe calkowita");
                }
            } while (!parsed);

            ProblemPlecakowy problemPlecakowy = new ProblemPlecakowy(iloscPrzedmiotow, ziarno);
            Console.WriteLine(problemPlecakowy);

            int pojemnosc;
            parsed = false;
            do
            {
                Console.WriteLine("Wprowadz pojemnosc plecaka: ");
                parsed = int.TryParse(Console.ReadLine(), out pojemnosc);
                if (!parsed)
                {
                    Console.WriteLine("Blad... Podaj liczbe calkowita");
                }
            } while (!parsed);

            Console.WriteLine(problemPlecakowy.Solve(pojemnosc));
        }
    }
}
