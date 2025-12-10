using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP_RESTAURANTE.MVVM.Modelo
{
    public class UsuarioDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Pasword { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
    }

    public class LoginReq
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
