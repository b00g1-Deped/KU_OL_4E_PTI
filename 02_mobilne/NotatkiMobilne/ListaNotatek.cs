using System.Collections.ObjectModel;

namespace NotatkiMobilne;

/// <summary>
/// Przechowuje notatki widoczne w aplikacji mobilnej i udostępnia operację ich dodawania.
/// ObservableCollection automatycznie powiadamia interfejs o nowym elemencie.
/// </summary>
public class ListaNotatek
{
    public ObservableCollection<string> Notatki { get; } = new()
    {
        "Sprawdzić termin oddania projektu INF.04",
        "Przygotować materiały na zajęcia z programowania",
        "Wysłać przypomnienie o wspólnej nauce"
    };

    /// <summary>
    /// Dodaje niepustą notatkę na końcu listy.
    /// </summary>
    /// <param name="tekst">Tekst wpisany przez użytkownika.</param>
    /// <returns><c>true</c>, gdy dodano notatkę; w przeciwnym razie <c>false</c>.</returns>
    public bool DodajNotatke(string? tekst)
    {
        if (string.IsNullOrWhiteSpace(tekst))
        {
            return false;
        }

        Notatki.Add(tekst.Trim());
        return true;
    }
}
