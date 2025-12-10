using APP_RESTAURANTE.MVVM.VIewModel;

namespace APP_RESTAURANTE.MVVM.Vistas;

public partial class NewPage1 : ContentPage
{
   
    public NewPage1()
	{
		InitializeComponent();
        BindingContext = new RequerimientoViewModel();
    }
}