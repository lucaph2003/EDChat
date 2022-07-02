using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDChat.Logica;

namespace EDChat.AccesoDatos
{
    class DocenteBD
    {
        //Metodo para Registrar Docente
        public void RegistrarNuevoUsuario(Docente docente, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "INSERT INTO docentes (nombre,apellido,password,ci,idasignatura)VALUES(@nombre,@apellido,@password,@ci,@idasignatura)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", docente.Nombre);
                comando.Parameters.AddWithValue("@apellido", docente.Apellido);
                comando.Parameters.AddWithValue("@password", docente.Password);
                comando.Parameters.AddWithValue("@ci", docente.Ci);
                comando.Parameters.AddWithValue("@idasignatura", docente.Asignatura.Idasignatura);
                codigo = comando.ExecuteNonQuery();
                mensaje = "Se han registrado el docente correctamente.";
            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se ha podido registrar el docente. " + ex.ToString();
            }
        }

        //Metodo para Verificar si existe la contrasenia
        public bool ExistePassword(string pPassword)
        {
            //Metodo para ver si la contrasenia ya existe
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT ci FROM docentes WHERE password LIKE @password";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@password", pPassword);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Metodo para obtener los atributos del usuario actual
        public Docente PorDni(string ciIngresado)
        {
            //Metodo para registrar por dni si no existe
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT * FROM docentes WHERE ci = @ci";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@ci", ciIngresado);

            reader = comando.ExecuteReader();

            Docente usuario = null;

            while (reader.Read())
            {
                usuario = new Docente();
                usuario.Id = int.Parse(reader["iddocente"].ToString());
                usuario.Password = reader["password"].ToString();
                usuario.Nombre = reader["nombre"].ToString();
                usuario.Apellido = reader["apellido"].ToString();
            }
            Conexion.closeConexion();
            return usuario;
        }

        //Metodo para actualizar los datos del perfil
        public void ActualizarDatos(Image pFotoPerfil, String pNombre, String pApellido, String pDni, int pId, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MemoryStream ms = new MemoryStream();
                pFotoPerfil.Save(ms, ImageFormat.Jpeg);
                byte[] aByte = ms.ToArray();

                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();

                MySqlCommand comando = new MySqlCommand("UPDATE docentes SET nombre = @nombre, apellido = @apellido, ci = @ci, fotoperfil = @fotoperfil WHERE iddocente = @iddocente", conexionBD);
                comando.Parameters.AddWithValue("@nombre", pNombre);
                comando.Parameters.AddWithValue("@apellido", pApellido);
                comando.Parameters.AddWithValue("@ci", pDni);
                comando.Parameters.AddWithValue("@fotoperfil", aByte);
                comando.Parameters.AddWithValue("@iddocente", pId);
                int ret = comando.ExecuteNonQuery();
                mensaje = "Se han actualizado correctamente los datos de perfil.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se han podido actualizar los datos de perfil. " + ex.ToString();
            }
        }

        //Metodo para listar los docentes
        public ArrayList ListaDocentes()
        {
            ArrayList lista = new ArrayList();

            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();
                MySqlDataReader reader;

                string sql = "SELECT * FROM docentes";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Docente usuario = null;
                    usuario = new Docente();
                    usuario.Id = int.Parse(reader["iddocente"].ToString());
                    usuario.Password = reader["password"].ToString();
                    usuario.Nombre = reader["nombre"].ToString();
                    usuario.Apellido = reader["apellido"].ToString();
                    usuario.Ci = reader["ci"].ToString();
                    usuario.Conexion = DateTime.Parse(reader["conexion"].ToString()); 
                    
                    if (usuario.Id != Session.id)
                    {
                        lista.Add(usuario);
                    }
                }

                Conexion.closeConexion();

            }
            catch (MySqlException ex) { }


            return lista;
        }

        //Metodo para actualizar la contrasenia de los docentes
        public void ActualizarPassword(string pPassword, int pId, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();

                MySqlCommand comando = new MySqlCommand("UPDATE docentes SET password = @password WHERE iddocente = @iddocente", conexionBD);
                comando.Parameters.AddWithValue("@password", pPassword);
                comando.Parameters.AddWithValue("@iddocente", pId);
                int ret = comando.ExecuteNonQuery();
                mensaje = "Se han actualizado correctamente los datos de perfil.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se han podido actualizar los datos de perfil. " + ex.ToString();
            }
        }

        //Metodo para obtener docente por ID
        public static Docente PorId(int pId)
        {
            //Metodo para registrar por dni si no existe
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT * FROM docentes WHERE iddocente = @IdDocente";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Iddocente", pId);

            reader = comando.ExecuteReader();

            Docente usuario = null;

            while (reader.Read())
            {
                usuario = new Docente();
                usuario.Id = int.Parse(reader["iddocente"].ToString());
                usuario.Password = reader["password"].ToString();
                usuario.Nombre = reader["nombre"].ToString();
                usuario.Apellido = reader["apellido"].ToString();
            }
            Conexion.closeConexion();
            return usuario;
        }


        //Metodo para obtener grupo
        public void ObtenerGrupo(int idDocente, out int idGrupo, out String nombreGrupo)
        {
            idGrupo = 0;
            nombreGrupo = "";

            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT g.idgrupo, g.Nombre FROM grupos g, alumnos_grupo a  where g.idgrupo = a.idgrupo and a.idalumno = @idalumno";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@iddocente", idDocente);

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                idGrupo = int.Parse(reader["idgrupo"].ToString());
                nombreGrupo = reader["Nombre"].ToString();
            }
            Conexion.closeConexion();
        }

        //Metodo para actualizar conexion
        public void ActualizarCoenxion(int pId, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();

                MySqlCommand comando = new MySqlCommand("UPDATE docentes SET conexion = CURTIME() WHERE iddocente = @iddocente", conexionBD);
                comando.Parameters.AddWithValue("@iddocente", pId);
                int ret = comando.ExecuteNonQuery();
                mensaje = "Se han actualizado correctamente los datos de perfil.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se han podido actualizar los datos de perfil. " + ex.ToString();
            }
        }

        

    }
}
