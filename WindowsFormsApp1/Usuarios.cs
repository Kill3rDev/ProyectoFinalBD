using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema
{
    class Usuarios //getters y setters de Usuarios 
    {
        int id;
        string usuario, password, apellido, nombre,email,about;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Password { get => password; set => password = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string About { get => about; set => about = value; }
    }
}
