using NotatkiKonsola;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine("=== APLIKACJA: MOJE NOTATKI ===");
Console.WriteLine();

var pierwszaNotatka = new Notatka(
    "Zakupy po zajęciach",
    "Kupić zeszyt do programowania i przygotować listę zadań.");

var drugaNotatka = new Notatka(
    "Powtórka przed sprawdzianem",
    "Przećwiczyć klasy, konstruktory, pola prywatne i metody.");

Console.WriteLine("NOTATKA 1");
pierwszaNotatka.WyswietlNotatke();
pierwszaNotatka.WyswietlDiagnostyke();
Console.WriteLine();

Console.WriteLine("NOTATKA 2");
drugaNotatka.WyswietlNotatke();
drugaNotatka.WyswietlDiagnostyke();
Console.WriteLine();

Console.WriteLine("Wniosek z testu: utworzono 2 notatki o identyfikatorach 1 i 2.");
Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć program.");
Console.ReadKey();