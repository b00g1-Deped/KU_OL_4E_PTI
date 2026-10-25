namespace NotatkiMobilne;

public partial class MainPage : ContentPage
{
    public ListaNotatek Lista { get; } = new();

    public MainPage()
    {
        InitializeComponent();
        BindingContext = Lista;
    }

    private void DodajButton_Clicked(object sender, EventArgs e)
    {
        Lista.DodajNotatke(NowaNotatkaEntry.Text);
        NowaNotatkaEntry.Text = string.Empty;
    }
}
