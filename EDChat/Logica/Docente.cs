using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using EDChat.AccesoDatos;
using System.Collections;


namespace EDChat.Logica
{
    class Docente
    {
        //Declaracion de los atributos de docentes
        int id;
        string nombre, apellido, password, conPassword, ci;
        Image fotoperfil;
        DateTime conexion;
        Asignatura asignatura;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Password { get => password; set => password = value; }
        public string ConPassword { get => conPassword; set => conPassword = value; }
        public string Ci { get => ci; set => ci = value; }
        public int Id { get => id; set => id = value; }
        public Image FotoPerfil { get => fotoperfil; set => fotoperfil = value; }
        public DateTime Conexion { get => conexion; set => conexion = value; }
        public Asignatura Asignatura { get => asignatura; set => asignatura = value; }

        //Metodos Tostring
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

        //Metodo puente para registrar usuarios
        public static void registrar(String pNombre, String pApellido, String pPassword, String pConPassword, String pCi,Asignatura pasignatura, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";

            Docente nuevoUsuario = new Docente();
            nuevoUsuario.Nombre = pNombre;
            nuevoUsuario.Apellido = pApellido;
            nuevoUsuario.Password = pPassword;
            nuevoUsuario.ConPassword = pConPassword;
            nuevoUsuario.Ci = pCi;
            nuevoUsuario.Asignatura = pasignatura;

            try
            {

                Logica.Control control = new Logica.Control();
                DocenteBD alumnoBD = new DocenteBD();

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

        //Metodo puente para actualizar los datos del usuario
        public static void actualizarDatos(Image pFotoPerfil, String pNombre, String pApellido, String pCi, int pId, out int codigo, out String mensaje)
        {

            DocenteBD docenteBD = new DocenteBD();
            docenteBD.ActualizarDatos(pFotoPerfil, pNombre, pApellido, pCi, pId, out codigo, out mensaje);

            Session.nombre = pNombre;
            Session.apellido = pApellido;
            Session.ci = pCi;
            Session.id = pId;
            Session.fotoperfil = pFotoPerfil;

        }

        //Metodo puente para listar los docentes
        public static ArrayList listaDocentes()
        {
            ArrayList lista = new ArrayList();

            DocenteBD docenteBD = new DocenteBD();

            return docenteBD.ListaDocentes();
        }

        //Metodo puente para cambiar la contrasenia
        public static void actualizarPassword(string pOldPassword, string pConPassword, string pPassword, int pId, out int codigo, out String mensaje)
        {
            if (pOldPassword == Session.password)
            {
                if (pPassword == pConPassword)
                {
                    DocenteBD docenteBD = new DocenteBD();
                    docenteBD.ActualizarPassword(pPassword, pId, out codigo, out mensaje);

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

        //Metodo puente para Listar los contactos
        public static ArrayList listaContactos()
        {
            ArrayList lista = new ArrayList();

            DocenteBD docenteBD = new DocenteBD();

            return docenteBD.ListaDocentes();
        }

        //Metodo puente para obtener el docente por si ID
        public static Docente porId(int pId)
        {
            Docente doc = DocenteBD.PorId(pId);
            return doc;
        }

        //Metodo puente para obtener grupo
        public static void obtenerGrupo(int idAlumno, out int idGrupo, out String nombreGrupo)
        {
            idGrupo = 0;
            nombreGrupo = "";

            DocenteBD docenteBD = new DocenteBD();
            docenteBD.ObtenerGrupo(idAlumno, out idGrupo, out nombreGrupo);

        }

        //Metodo puente para actualizar hora
        public static void actualizarHora(int pId, out int codigo, out String mensaje)
        {

            DocenteBD docenteBD = new DocenteBD();
            docenteBD.ActualizarCoenxion(pId, out codigo, out mensaje);

            Session.id = pId;

        }
    }
}
