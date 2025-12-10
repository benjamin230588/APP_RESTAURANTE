using Microsoft.VisualBasic;
using Newtonsoft.Json;

using System.Reflection;
using APP_RESTAURANTE.MVVM.VIewModel;

namespace APP_RESTAURANTE.MVVM.Vistas;

public partial class LoginView : ContentPage
{
	//public Login objeto { get; set; }
    public LoginView()
	{
		InitializeComponent();

        BindingContext = new LoginviewModel();
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {

    }

  
}