using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDChat.Logica
{
    class Control
    {
        public string ctrlRegistro(Docentes docentes)
        {
            Modelo modelo = new Modelo();
            string respuesta = "";


            if (string.IsNullOrEmpty(docentes.Nombre) || string.IsNullOrEmpty(docentes.Apellido) || string.IsNullOrEmpty(docentes.Password) || string.IsNullOrEmpty(docentes.ConPassword) || string.IsNullOrEmpty(docentes.Dni))
            {
                respuesta = "Debe llenar todos los campos";


            }
            else
            {
                if (docentes.Password == docentes.ConPassword)
                {
                    if (modelo.existePassword(docentes.Password))
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
            Docentes datosDocentes = null;

            if (string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(password))
            {
                respuesta = "Debe llenar todos los campos";

            }
            else
            {
                datosDocentes = modelo.porDni(dni);

                if (datosDocentes == null)
                {
                    respuesta = "El usuario no existe";

                }
                else
                {
                    if (datosDocentes.Password != password)
                    {
                        respuesta = "El usuario o la contraseña no coinciden";

                    }
                    else
                    {

                        Session.id = datosDocentes.Id;
                        Session.dni = dni;
                        Session.nombre = datosDocentes.Nombre;
                        Session.apellido = datosDocentes.Apellido;

                    }


                }

            }
            return respuesta;
        }
    }
}
