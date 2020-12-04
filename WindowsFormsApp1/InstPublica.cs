using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class InstPublica //getters setters de institucion publica
    {
       int idInstitucionServico;
       String nombreResponsable, apellidosResponsable, nombreDependencia, direccion, telefono, telefono2, correoE, fax, ciudad;

        public int IdInstitucionServico { get => idInstitucionServico; set => idInstitucionServico = value; }
        public String NombreResponsable { get => nombreResponsable; set => nombreResponsable = value; }
        public String ApellidosResponsable { get => apellidosResponsable; set => apellidosResponsable = value; }
        public String NombreDependencia { get => nombreDependencia; set => nombreDependencia = value; }
        public String Direccion { get => direccion; set => direccion = value; }
        public String Telefono { get => telefono; set => telefono = value; }
        public String Telefono2 { get => telefono2; set => telefono2 = value; }
        public String CorreoE { get => correoE; set => correoE = value; }
        public String Fax { get => fax; set => fax = value; }
        public String Ciudad { get => ciudad; set => ciudad = value; }
      


    }
}
