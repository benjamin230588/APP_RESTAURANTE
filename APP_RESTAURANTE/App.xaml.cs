using APP_RESTAURANTE.MVVM.Vistas;

namespace APP_RESTAURANTE
{
    public partial class App : Application
    {
        public static INavigation Navigate { get; internal set; }
        public static PrincipalMasterView MenuApp { get; internal set; }
        public App()
        {
            InitializeComponent();
            //   change

            MainPage = new NavigationPage(new LoginView());
            
        }

        //protected override Window CreateWindow(IActivationState? activationState)
        //{
        //    return new Window(new AppShell());
        //}
    }
}