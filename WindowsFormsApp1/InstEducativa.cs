using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class InstEducativa //getter y setters de institucion edicativoa 
    {
        int idInstitucionEducativa;
        string nombreInstitucion,direccion,telefono,telefono2,correoE,ciudad,nombreEncargado,apellidosEncargado;

        public int IdInstitucionEducativa { get => idInstitucionEducativa; set => idInstitucionEducativa = value; }
        public string NombreInstitucion { get => nombreInstitucion; set => nombreInstitucion = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Telefono2 { get => telefono2; set => telefono2 = value; }
        public string CorreoE { get => correoE; set => correoE = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public string NombreEncargado { get => nombreEncargado; set => nombreEncargado = value; }
        public string ApellidosEncargado { get => apellidosEncargado; set => apellidosEncargado = value; }

    }
}
