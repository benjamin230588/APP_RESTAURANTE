using APP_RESTAURANTE.MVVM.Modelo;
using APP_RESTAURANTE.RepositorioDB;

namespace APP_RESTAURANTE.MVVM.Vistas;

public partial class SQLLITE : ContentPage
{
     
    private readonly Repository alumnodb;
    public SQLLITE()
	{
		InitializeComponent();
        alumnodb = new Repository();
        //DBBASE = new Repository();

    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        ALUMNO obj = new ALUMNO();
        obj.Name = "CARLA";
        obj.Phone = "999SS";


        alumnodb.AddOrUpdate(obj);


    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        List<ALUMNO> lista = alumnodb.GetAll();
        string cade = "ddd";
    }
}