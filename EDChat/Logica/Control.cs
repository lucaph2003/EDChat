using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDChat.AccesoDatos;

namespace EDChat.Logica
{
    class Control
    {
        public string ctrlRegistro(Alumno alumnos)
        {
            //Metodo para verificar que la contrasenia no exista con todos los casos
            AlumnoBD alumnoBD = new AlumnoBD();
            string respuesta = "";

            if (string.IsNullOrEmpty(alumnos.Nombre) || string.IsNullOrEmpty(alumnos.Apellido) || string.IsNullOrEmpty(alumnos.Password) || string.IsNullOrEmpty(alumnos.ConPassword) || string.IsNullOrEmpty(alumnos.Ci))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                if (alumnos.Password == alumnos.ConPassword)
                {
                    if (alumnoBD.ExistePassword(alumnos.Password))
                    {
                        respuesta = "Esta contraseña ya esta usada";
                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }
            }
            return respuesta;
        }

        public string ctrlLogin(string ci, string password)
        {
            //Metodo para el login, crea la session
            AlumnoBD alumnoBD = new AlumnoBD();
            string respuesta = "";
            Alumno datosAlumnos = null;

            if (string.IsNullOrEmpty(ci) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";
            }
            else
            {
                datosAlumnos = alumnoBD.porDni(ci);

                if (datosAlumnos == null)
                {
                    respuesta = "El usuario no existe";
                }
                else
                {
                    if (datosAlumnos.Password != password)
                    {
                        respuesta = "El usuario o la contraseña no coinciden";
                    }
                    else
                    {
                        Session.id = datosAlumnos.Id;
                        Session.ci = ci;
                        Session.nombre = datosAlumnos.Nombre;
                        Session.apellido = datosAlumnos.Apellido;
                        Session.password = datosAlumnos.Password;
                        Session.fotoperfil = datosAlumnos.FotoPerfil;
                    }


                }

            }
            return respuesta;
        }

    }
}
