using Microsoft.Maui.Controls;

namespace APP_RESTAURANTE.MVVM.Vistas;

public partial class PrincipalMasterView : FlyoutPage
{
	public PrincipalMasterView()
    {
		InitializeComponent();
        App.Navigate = Navigacion.Navigation;
        App.MenuApp = this;

    }
}