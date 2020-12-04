using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Reporte //getters y setters de reporte
    {
        
        String nombre, apellidos, semestre, programaSS, matricula, nombreDependencia, nombreInstitucion;

        public String Nombre { get => nombre; set => nombre = value; }
        public String Apellidos { get => apellidos; set => apellidos = value; }
        public String Semestre { get => semestre; set => semestre = value; }
        public String ProgramaSS { get => programaSS; set => programaSS = value; }
        public String Matricula { get => matricula; set => matricula = value; }
        public String NombreDependencia { get => nombreDependencia; set => nombreDependencia = value; }
        public String NombreInstitucion { get => nombreInstitucion; set => nombreInstitucion = value; }

    }
}
