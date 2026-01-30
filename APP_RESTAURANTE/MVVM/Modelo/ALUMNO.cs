using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_RESTAURANTE.MVVM.Modelo
{
        [Table("ALUMNO")]
        public class ALUMNO 
        {

            [PrimaryKey,AutoIncrement]
            public int AlumnoId { get; set; }
            public string Name { get; set; }
           
            public string Phone { get; set; }
           
        }
}
