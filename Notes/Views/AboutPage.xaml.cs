using Notes.Models;

namespace Notes.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
		if(BindingContext is About about)
		{
            await Launcher.Default.OpenAsync("https://aka.ms/maui");
        }	
    }
}