using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using EDChat.AccesoDatos;
using System.Collections;

//En esta clase se declaran el objeto alumno con todos sus atributos
namespace EDChat.Logica
{
    public class Alumno
    {
        //Declaracion de alumnos
        int id;
        string nombre, apellido, password, conPassword, ci;
        Image fotoperfil;
        DateTime conexion;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Password { get => password; set => password = value; }
        public string ConPassword { get => conPassword; set => conPassword = value; }
        public string Ci { get => ci; set => ci = value; }
        public int Id { get => id; set => id = value; }
        public Image FotoPerfil { get => fotoperfil; set => fotoperfil = value; }
        public DateTime Conexion { get => conexion; set => conexion = value; }

        override
        public String ToString()
        {
            return Ci + " - " + Nombre + " " + Apellido;
        }
        public string cedula()
        {
            return Ci;
        }
        public string nombreususario()
        {
            return Nombre;
        }
        public string conexionUsuario()
        {
            return Conexion.ToString();
        }

        public string apellidoususario()
        {
            return Apellido;
        }

        //Metodo puente para registrar Alumnos
        public static void registrar(String pNombre, String pApellido, String pPassword, String pConPassword, String pCi, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";

            Alumno nuevoUsuario = new Alumno();
            nuevoUsuario.Nombre = pNombre;
            nuevoUsuario.Apellido = pApellido;
            nuevoUsuario.Password = pPassword;
            nuevoUsuario.ConPassword = pConPassword;
            nuevoUsuario.Ci = pCi;

            try
            {

                Logica.Control control = new Logica.Control();
                AlumnoBD alumnoBD = new AlumnoBD();

                //Valido que se hayan cargado todos los datos en el formulario
                string respuesta = control.ctrlRegistro(nuevoUsuario);

                if (respuesta.Length > 0)
                {
                    codigo = -1;
                    mensaje = respuesta;
                }
                else
                {
                    //Paso validacion y llamo a metodo que guarda el nuevo Usuario
                    alumnoBD.RegistrarNuevoUsuario(nuevoUsuario, out codigo, out mensaje);

                    //Si resultado es cero hubo algun error
                  
                }
            }
            catch (Exception ex)
            {
                codigo = -1;
                mensaje = "No se ha podido registrar el alumno. " + ex.ToString(); ;
            }
        }

        //Metodo puente para actualizar datos alumno
        public static void actualizarDatos(Image pFotoPerfil, String pNombre, String pApellido, String pCi, int pId, out int codigo, out String mensaje)
        {

            AlumnoBD alumnoBD = new AlumnoBD();
            alumnoBD.ActualizarDatos(pFotoPerfil, pNombre, pApellido, pCi, pId, out codigo, out mensaje);
            
            Session.nombre = pNombre;
            Session.apellido = pApellido;
            Session.ci = pCi;
            Session.id = pId;
            Session.fotoperfil = pFotoPerfil;

        }

        //Metodo puente para ver nombre del alumno
        public static ArrayList verNombre(int pid)
        {
            return Alumno.verNombre(pid); ;
        }

        //Metodo puente para listar alumnos
        public static ArrayList listaAlumnos()
        {
            ArrayList lista = new ArrayList();

            AlumnoBD alumnoBD = new AlumnoBD();

            return alumnoBD.ListaAlumnos();
        }

        //Metodo puente para actualizar contrasenia
        public static void actualizarPassword(string pOldPassword, string pConPassword, string pPassword, int pId, out int codigo, out String mensaje)
        {
            if(pOldPassword == Session.password)
            {
                if(pPassword == pConPassword)
                {
                    AlumnoBD alumnoBD = new AlumnoBD();
                    alumnoBD.ActualizarPassword(pPassword, pId, out codigo, out mensaje);

                    Session.password = pPassword;
                    Session.id = pId;
                }
                else
                {
                    codigo = -1;
                    mensaje = "Sus contrasenias no coinciden.";
                }
                
            }
            else
            {
                codigo = -1;
                mensaje = "Su contrasenia actual esta mal.";
            }

        }

        //Metodo puente para listar contactos
        public static ArrayList listaContactos()
        {
            ArrayList lista = new ArrayList();

            AlumnoBD alumnoBD = new AlumnoBD();
           
            return alumnoBD.ListaAlumnos();
        }

        //Metodo puente para registrar alumnos x id
        public static Alumno porId(int pId)
        {
            Alumno al = AlumnoBD.porId(pId);
            return al;
        }

        //Metodo puente para actualizar hora
        public static void actualizarHora(int pId, out int codigo, out String mensaje)
        {

            AlumnoBD alumnoBD = new AlumnoBD();
            alumnoBD.ActualizarCoenxion(pId, out codigo, out mensaje);

            Session.id = pId;

        }

        //Metodo puente para obtener grupo
        public static void obtenerGrupo(int idAlumno, out int idGrupo, out String nombreGrupo)
        {
            idGrupo = 0;
            nombreGrupo = "";

            AlumnoBD alumnoBD = new AlumnoBD();
            alumnoBD.ObtenerGrupo(idAlumno, out idGrupo, out nombreGrupo);

        }

    }
}
