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
    
        public static class Database
        {
            private static SQLiteConnection _connection;
            private static readonly object _lock = new();

            public static SQLiteConnection Connection
            {
                get
                {
                    if (_connection == null)
                    {
                        lock (_lock)
                        {
                            if (_connection == null)
                            {
                                _connection = new SQLiteConnection(
                                    Constantes.DatabasePath,
                                    Constantes.Flags);
                            _connection.CreateTable<ALUMNO>();
                        }
                        }
                    }
                    return _connection;
                }cc
            }
        }

    }

