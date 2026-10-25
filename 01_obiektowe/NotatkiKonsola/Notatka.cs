namespace NotatkiKonsola{
    /// <summary>
    /// Klasa Notatka przechowuje informacje o notatce.
    /// Każda notatka ma swój numer, tytuł i treść.
    /// Autor: Oleksandr Kulyk 4E
    /// </summary>
    public class Notatka
    {
        private static int licznik;
        private readonly int identyfikator;
        private readonly string tytul;
        private readonly string tresc;

        /// <summary>
        /// Tworzy nową notatkę i nadaje jej numer.
        /// </summary>
        /// <param name="tytul">Tytuł notatki.</param>
        /// <param name="tresc">Treść notatki.</param>
        public Notatka(string tytul, string tresc)
        {
            licznik++;
            identyfikator = licznik;
            this.tytul = tytul;
            this.tresc = tresc;
        }

        /// <summary>
        /// Wyświetla tytuł i treść notatki.
        /// </summary>
        public void WyswietlNotatke()
        {
            Console.WriteLine($"Tytuł: {tytul}");
            Console.WriteLine($"Treść: {tresc}");
        }

        /// <summary>
        /// Wyświetla wszystkie informacje o notatce.
        /// </summary>
        public void WyswietlDiagnostyke()
        {
            Console.WriteLine($"Licznik: {licznik}; Identyfikator: {identyfikator}; Tytuł: {tytul}; Treść: {tresc}");
        }
    }
}