using Sistema;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Control

    {

        public string ctrlRegistro(Usuarios usuario) //se lleva acabo el registro de los usuarios
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Password) || string.IsNullOrEmpty(usuario.Nombre)) //valida la contraseña y nombre de usuario
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                usuario.Password = generarSHA1(usuario.Password);
                modelo.registro(usuario);

            }


            return respuesta;

        }
        public string ctrlAlumno(Alumno alumno) //se lleva acabo el registro de los usuarios
        {
            Modelo modelo = new Modelo();
            string respuesta = "";

            if (string.IsNullOrEmpty(alumno.Nombre) || string.IsNullOrEmpty(alumno.Control) || string.IsNullOrEmpty(alumno.Apellido)) //valida que este nombre,noContro y apellido
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                
                modelo.registroalumno(alumno);

            }


            return respuesta;

        }


        public string ctrlLogin(string usuario, string password) //valida la contraseña y nombre de usuario en el login
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Usuarios datosUsuario = null;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosUsuario = modelo.getUsuario(usuario);

                if (datosUsuario == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if (datosUsuario.Password != generarSHA1(password))
                    {
                        respuesta = "El usuario y/o contraseña no coinciden";
                    }
                
              
                }
            }
            return respuesta;
        }



        private string generarSHA1(string cadena) //encripta la contraseña de registro 
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();

            result = sha.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }

            return sb.ToString();
        }
    }
}

