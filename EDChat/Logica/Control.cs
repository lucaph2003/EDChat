using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDChat.Logica
{
    class Control
    {
        public string ctrlRegistro(Alumnos alumnos)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";


            if (string.IsNullOrEmpty(alumnos.Nombre) || string.IsNullOrEmpty(alumnos.Apellido) || string.IsNullOrEmpty(alumnos.Password) || string.IsNullOrEmpty(alumnos.ConPassword) || string.IsNullOrEmpty(alumnos.Dni))
            {
                respuesta = "Debe llenar todos los campos";


            }
            else
            {
                if (alumnos.Password == alumnos.ConPassword)
                {
                    if (modelo.existePassword(alumnos.Password))
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

        public string ctrlLogin(string dni, string password)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";
            Alumnos datosAlumnos = null;

            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";

            }
            else
            {
                datosAlumnos = modelo.porDni(dni);

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
                        Session.dni = dni;
                        Session.nombre = datosAlumnos.Nombre;
                        Session.id_tipo = datosAlumnos.Id_tipo;
                        Session.apellido = datosAlumnos.Apellido;

                    }


                }

            }
            return respuesta;
        }

    }
}
