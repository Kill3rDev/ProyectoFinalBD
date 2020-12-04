using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Alumno //Clase para registrar alumnos
    {
        int id,horas;
        string control, carrera, apellido, nombre, nooficio, semestre,programa,telefono,telefono2,correo;

        public string Nombre { get => nombre; set => nombre = value; }

        public string Apellido { get => apellido; set => apellido = value; }

        
        public string Control { get => control; set => control = value; }

        public string Carrera { get => carrera; set => carrera = value; }

        public string Semestre { get => semestre; set => semestre = value; }

        public string NoOficio { get => nooficio; set => nooficio = value; }

        public string Programa { get => programa; set => programa = value; }

        public string Telefono { get => telefono; set => telefono = value; }
        public string Telefono2 { get => telefono2; set => telefono2 = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Horas { get => horas; set => horas = value; }

    }
}
