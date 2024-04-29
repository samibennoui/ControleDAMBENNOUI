using Microsoft.Maui.Controls.Compatibility.Platform.Android;
using static Android.Webkit.ConsoleMessage;

namespace ControleDAMBENNOUI;

public partial class Hello : ContentPage
{
    private object passwordEntry;

    public Hello()
	{
		InitializeComponent();
	}

    public partial class MainPage : ContentPage
    {
        
    }

   
    private void Button_Clicked(object sender, EventArgs e)
    { 
        
    }


    int c = 0;
    private void Button_Clicked_2(object sender, EventArgs e)
    {
        
        {
            if (valider.Text == "DAMP2024")
            {
                c++;
                message.Text = $"bravoo...!le mot de pass etait correct{c} fois";
                this.Navigation.PushAsync(new page2());
            } else
            {
                message.Text = "try again..!";

            }

            
        }
}
}
