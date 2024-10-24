internal class Program
{
    private static void Main(string[] args)
    {
        void Menu()
        {
            Console.WriteLine("1. Ustal budżet miesięczny");
            Console.WriteLine("2. Zmień datę wypłaty");
            Console.WriteLine("X. Dodaj transakcję");
            Console.WriteLine("X. Wyświetl sumę wydatków / przychodów");
            Console.WriteLine("X. Wyświetl wszystkie transakcje z ostatnich 24 miesięcy");
            Console.WriteLine("X. Oblicz średnią wydatków w ciągu miesiąca");
            Console.WriteLine("X. Wyświetl wydatki z konkretnego miesiąca i roku");
            Console.WriteLine("X. Zapisz do pliku");
            Console.WriteLine("X. Wczytaj z pliku");
            Console.WriteLine("X. Wyjście");
        }

        void UstalBudzetMiesieczny()
        {
            Console.Write("Podaj nowy budżet miesięczny: ");
            double budzet = double.Parse(Console.ReadLine());
            Console.WriteLine($"Budżet wynosi: {budzet}");
        }

        void DodajWydatek()
        {
            Console.WriteLine("Podaj kwotę wydatku:");
            double wydatek = double.Parse(Console.ReadLine());
            Console.WriteLine($"Dodano wydatek w kwocie: {wydatek}");
        }

        void WyswietlSumeWydatkow()
        {
            Console.WriteLine("Suma wydatków wynosi: ");
        }

        void WyswietlWszystkieWydatki()
        {
            Console.WriteLine("Wszystkie wydatki z ostatnich 24 miesięcy:");
        }

        void ObliczSredniaWydatkow()
        {
            Console.WriteLine("Średnia wydatków w ciągu miesiąca wynosi: ");
        }

        void WyswietlWydatkiZKonkretnegoMiesiacaIRoku()
        {
            Console.WriteLine("Podaj miesiąc:");
            int miesiac = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj rok:");
            int rok = int.Parse(Console.ReadLine());
            Console.WriteLine($"Wydatki z miesiąca {miesiac} roku {rok}:");
        }

        void ZapiszDoPliku()
        {
            Console.WriteLine("Zapisano do pliku");
        }

        void WczytajZPliku()
        {
            Console.WriteLine("Wczytano z pliku");
        }

        int wybor;
        do
        {
            Menu();
            wybor = int.Parse(Console.ReadLine());
            switch (wybor)
            {
                case 1:
                    UstalBudzetMiesieczny();
                    break;
                case 2:
                    DodajWydatek();
                    break;
                case 3:
                    WyswietlSumeWydatkow();
                    break;
                case 4:
                    WyswietlWszystkieWydatki();
                    break;
                case 5:
                    ObliczSredniaWydatkow();
                    break;
                case 6:
                    WyswietlWydatkiZKonkretnegoMiesiacaIRoku();
                    break;
                case 7:
                    ZapiszDoPliku();
                    break;
                case 8:
                    WczytajZPliku();
                    break;
                case 9:
                    Console.WriteLine("Do widzenia!");
                    break;
                default:
                    Console.WriteLine("Nieprawidłowy wybór");
                    break;
            }
        } while (wybor != 9);
    }
}