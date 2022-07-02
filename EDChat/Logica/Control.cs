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
            //Metodo para verificar que el usuario sea unico
            public string ctrlRegistro(Docente docente)
            {
                //Metodo para verificar que la contrasenia no exista con todos los casos
                DocenteBD docenteBD = new DocenteBD();
                string respuesta = "";

                if (string.IsNullOrEmpty(docente.Nombre) || string.IsNullOrEmpty(docente.Apellido) || string.IsNullOrEmpty(docente.Password) || string.IsNullOrEmpty(docente.ConPassword) || string.IsNullOrEmpty(docente.Ci))
                {
                    respuesta = "Debe llenar todos los campos";
                }
                else
                {
                    if (docente.Password == docente.ConPassword)
                    {
                        if (docenteBD.ExistePassword(docente.Password))
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

            //MEtodo para el correcto funcionamiento del login
            public string ctrlLogin(string ci, string password)
            {
                //Metodo para el login, crea la session
                DocenteBD docenteBD = new DocenteBD();
                string respuesta = "";
                Docente datosDocentes = null;

                if (string.IsNullOrEmpty(ci) || string.IsNullOrEmpty(password))
                {
                    respuesta = "Debe llenar todos los campos";
                }
                else
                {
                    datosDocentes = docenteBD.PorDni(ci);

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
                            Session.ci = ci;
                            Session.nombre = datosDocentes.Nombre;
                            Session.apellido = datosDocentes.Apellido;
                            Session.password = datosDocentes.Password;
                            Session.fotoperfil = datosDocentes.FotoPerfil;
                    }


                    }

                }
                return respuesta;
            }

    }
}
