using APP_RESTAURANTE.ClienteHttp;
using APP_RESTAURANTE.Helpers;
using APP_RESTAURANTE.MVVM.Modelo;
using CommunityToolkit.Maui.Views;
using Microsoft.Maui.Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace APP_RESTAURANTE.MVVM.VIewModel
{
    public class RequerimientoViewModel : BaseViewModel
    {

        private bool _flgindicador;
        private bool _flgrefresh;
        private ObservableCollection<RequerimientoDTO> _listarequerimiento;
       // public string Plataforma { get; set; }
        public RequerimientoViewModel()
        {

            // Navigation = navigation;
         //   Plataforma = DeviceInfo.Platform.ToString();


            listarequerimiento = new ObservableCollection<RequerimientoDTO>();
            Task.Run(async () => await MostrarLista());
           

        }

        public bool flgrefresh
        {
            get { return _flgrefresh; }
            set { SetValue(ref _flgrefresh, value); }
        }
        public bool flgindicador
        {
            get { return _flgindicador; }
            set { SetValue(ref _flgindicador, value); }
        }

        public ObservableCollection<RequerimientoDTO> listarequerimiento
        {
            get { return _listarequerimiento; }
            set { SetValue(ref _listarequerimiento, value); }
        }


        public async Task MostrarLista(int skip = 0, int tipo = 0)
        {
            Respuesta res;
            try
            {
                var objeto = new Paginacion { pagine = 40, skip = skip };
                ResulLista<RequerimientoDTO> objres = new ResulLista<RequerimientoDTO>();

                //List<RequerimientoDTO> objres = new List<RequerimientoDTO>();
                flgindicador = true;
                res = await GenericLH.GetAll<Paginacion>(Constantes.url + Constantes.api_getlistarequerimiento, objeto);
                if (res.codigo == 1)
                {
                    objres = JsonConvert.DeserializeObject<ResulLista<RequerimientoDTO>>(JsonConvert.SerializeObject(res.data));

                }
                // listarequerimiento = objres;
                if (tipo == 0)
                {
                    listarequerimiento.Clear();
                    flgrefresh = false;
                }

                for (int i = 0; i < objres.lista.Count; i++)
                {
                    bool valida = listarequerimiento.Where(x => x.Id == objres.lista[i].Id).Any();
                    if (!valida)
                    {
                        listarequerimiento.Add(objres.lista[i]);
                    }

                }
                flgindicador = false;
            }
            catch (Exception ex)
            {
                flgindicador = false;
                await DisplayAlert("Error", "Error de Conexion", "Cancelar");
            }


        }
        public async Task MostrarListaRefrsh()
        {
            await MostrarLista(listarequerimiento.Count, 1);

        }

      


       

      
        public ICommand RefreshComand => new Command(async () => await MostrarLista());
        public ICommand RefreshIncrementComand => new Command(async () => await MostrarListaRefrsh());


    }


}
