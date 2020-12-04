using MySql.Data.MySqlClient;
using Sistema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Modelo
    {
        public int registro(Usuarios usuario)  //registra usuarios en la bd
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO usuarios (usuario, password, nombre,apellido, email) VALUES(@usuario, @password, @nombre, @apellido,@email)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario.Usuario);
            comando.Parameters.AddWithValue("@password", usuario.Password);
            comando.Parameters.AddWithValue("@nombre", usuario.Nombre);
            comando.Parameters.AddWithValue("@apellido", usuario.Apellido);
            comando.Parameters.AddWithValue("@email", usuario.Email);
          

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public List<Alumno> mostrarAlumno() //muestra alumno
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            string sql = "select * from alumno";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            List<Alumno> resultado = new List<Alumno>();

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
                {
                Alumno ojeto = new Alumno();
                ojeto.Nombre=reader.GetString("Nombre");
                ojeto.Apellido=reader.GetString("Apellidos"); 
                ojeto.Control = reader.GetString("Matricula");
                ojeto.Carrera = reader.GetString("Carrera");
                ojeto.Semestre = reader.GetString("Semestre");
                ojeto.Programa = reader.GetString("ProgramaSS");
                ojeto.Telefono = reader.GetString("NoTelefono");
                ojeto.Telefono2 = reader.GetString("NoTelefono2");
                ojeto.Correo = reader.GetString("CorreoE");
                ojeto.Horas = reader.GetInt32("HorasRealizadas");
                ojeto.NoOficio = reader.GetString("NoOficio");
                resultado.Add(ojeto);
                }
            comando.Dispose();
            conexion.Close();
            conexion.Dispose();
          return resultado;
        }

        public List<Reporte> GenReport() //Genera reporte
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
            string sql = "select a.Nombre, a.Apellidos, a.Semestre, a.ProgramaSS, a.Matricula, ss.NombreDependencia, id.NombreInstitucion from alumno a join institucioneducativa id on id.idInstitucionEducativa = a.idInstitucionEducativa join institucionservico ss on ss.idInstitucionServico = a.idInstitucionServico order by a.Matricula desc" ;
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            List<Reporte> resultado = new List<Reporte>();

            MySqlDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Reporte ojeto = new Reporte();
                ojeto.Nombre = reader.GetString("Nombre");
                ojeto.Apellidos = reader.GetString("Apellidos");
                ojeto.Matricula = reader.GetString("Matricula");
                ojeto.ProgramaSS = reader.GetString("ProgramaSS");
                ojeto.Semestre = reader.GetString("Semestre");
                ojeto.NombreDependencia = reader.GetString("NombreDependencia");
                ojeto.NombreInstitucion = reader.GetString("NombreInstitucion");          
                resultado.Add(ojeto);
            }
            comando.Dispose();
            conexion.Close();
            conexion.Dispose();
            return resultado;
        }


        public int registroalumno(Alumno alum) //se mandan los datos a la base de datos en la tabla alumno
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO alumno (idInstitucionServico,idInstitucionEducativa,Nombre,Apellidos,Matricula,Carrera,Semestre,ProgramaSS,NoTelefono,NoTelefono2,CorreoE,HorasRealizadas,NoOficio) VALUES(@idInstitucionServico,@idInstitucionEducativa,@Nombre,@Apellidos,@Matricula,@Carrera,@Semestre,@ProgramaSS,@NoTelefono,@NoTelefono2,@CorreoE,@HorasRealizadas,@NoOficio)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idInstitucionServico", "1");
            comando.Parameters.AddWithValue("@idInstitucionEducativa", "1" );
            comando.Parameters.AddWithValue("@Nombre", alum.Nombre);
            comando.Parameters.AddWithValue("@Apellidos", alum.Apellido);
            comando.Parameters.AddWithValue("@Matricula", alum.Control);
            comando.Parameters.AddWithValue("@Carrera", alum.Carrera);
            comando.Parameters.AddWithValue("@Semestre", alum.Semestre);
            comando.Parameters.AddWithValue("@ProgramaSS", alum.Programa);
            comando.Parameters.AddWithValue("@NoTelefono", alum.Telefono);
            comando.Parameters.AddWithValue("@NoTelefono2", alum.Telefono2);
            comando.Parameters.AddWithValue("@CorreoE", alum.Correo);
            comando.Parameters.AddWithValue("@HorasRealizadas", alum.Horas);
            comando.Parameters.AddWithValue("@NoOficio", alum.NoOficio);
            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public Usuarios getUsuario(string usuario) //optiene usuario para ingresar en el login
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT id, password, nombre FROM usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            Usuarios usr = null;

            while (reader.Read())
            {
                usr = new Usuarios();
                usr.Id = int.Parse(reader["id"].ToString());
                usr.Password = reader["password"].ToString();
                usr.Nombre = reader["nombre"].ToString();

            }
            return usr;
        }
    }
}