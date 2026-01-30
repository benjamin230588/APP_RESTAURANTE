using APP_RESTAURANTE.Helpers;
using APP_RESTAURANTE.MVVM.Modelo;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_RESTAURANTE.RepositorioDB
{
    public class Repository
    {
        //SQLiteConnection connection;
        public string StatusMessage { get; set; }
        private SQLiteConnection connection => Database.Connection;

        public Repository()
        {
            //connection =
            //     new SQLiteConnection(Constantes.DatabasePath,
            //     Constantes.Flags);
            //connection.CreateTable<ALUMNO>();
        }

        public void AddOrUpdate(ALUMNO customer)
        {
            int result = 0;
            try
            {
                if (customer.AlumnoId != 0)
                {
                    result =
                         connection.Update(customer);
                    StatusMessage =
                         $"{result} row(s) updated";
                }
                else
                {
                    result = connection.Insert(customer);
                    StatusMessage =
                         $"{result} row(s) added";
                }

            }
            catch (Exception ex)
            {
                StatusMessage =
                     $"Error: {ex.Message}";
            }
        }

        public List<ALUMNO> GetAll()
        {
            try
            {
                return connection.Table<ALUMNO>().ToList();
            }
            catch (Exception ex)
            {
                StatusMessage =
                     $"Error: {ex.Message}";
            }
            return null;
        }

       

    
        public ALUMNO Get(int id)
        {
            try
            {
                return
                     connection.Table<ALUMNO>()
                     .FirstOrDefault(x => x.AlumnoId == id);
            }
            catch (Exception ex)
            {
                StatusMessage =
                     $"Error: {ex.Message}";
            }
            return null;
        }

       
    }
}
