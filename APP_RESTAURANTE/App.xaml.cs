using APP_RESTAURANTE.MVVM.Vistas;
using APP_RESTAURANTE.RepositorioDB;

namespace APP_RESTAURANTE
{
    public partial class App : Application
    {
        public static INavigation Navigate { get; internal set; }
        public static PrincipalMasterView MenuApp { get; internal set; }
        //private static Repository _db;
        //private static readonly object _lock = new();

        //public static Repository dbbase {
        //    get
        //    {
        //        if (_db == null)
        //        {
        //            lock (_lock)
        //            {
        //                if (_db == null)
        //                    _db = new Repository();
        //            }
        //        }
        //        return _db;
        //    }  
                    
        //   }
        public App()
        {
            InitializeComponent();
            //   change

            MainPage = new NavigationPage(new SQLLITE());
            
        }

        //protected override Window CreateWindow(IActivationState? activationState)
        //{
        //    return new Window(new AppShell());
        //}
    }
}