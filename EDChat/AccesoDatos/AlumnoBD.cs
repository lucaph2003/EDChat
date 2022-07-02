using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDChat.Logica;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing;
using System.Collections;

namespace EDChat.AccesoDatos
{
    class AlumnoBD
    {
        //Metodo para registrar nuevo usuario
        public void RegistrarNuevoUsuario(Alumno alumno, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "INSERT INTO alumnos (nombre, apellido, password, ci, idalumno) VALUES(@nombre, @apellido, @password, @ci, @idalumno)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@nombre", alumno.Nombre);
                comando.Parameters.AddWithValue("@apellido", alumno.Apellido);
                comando.Parameters.AddWithValue("@password", alumno.Password);
                comando.Parameters.AddWithValue("@ci", alumno.Ci);
                comando.Parameters.AddWithValue("@idalumno", alumno.Id);
                codigo = comando.ExecuteNonQuery();
                mensaje = "Se ha registrado el alumno correctamente.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se ha podido registrar el alumno. " + ex.ToString();
            }
        }

        //Metodo para verificar si la contrasenia existe
        public bool ExistePassword(string pPassword)
        {
            //Metodo para ver si la contrasenia ya existe
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT ci FROM alumnos WHERE password LIKE @password";
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

        //Metodo para obtener usuario con ci
        public Alumno porDni(string ciIngresado)
        {
            //Metodo para registrar por ci si no existe
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT * FROM alumnos WHERE ci = @ci";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@ci", ciIngresado);

            reader = comando.ExecuteReader();

            Alumno usuario = null;

            while (reader.Read())
            {
                usuario = new Alumno();
                usuario.Id = int.Parse(reader["idalumno"].ToString());
                usuario.Password = reader["password"].ToString();
                usuario.Nombre = reader["nombre"].ToString();
                usuario.Apellido = reader["apellido"].ToString();
                if (!Convert.IsDBNull(reader["fotoperfil"]))
                {
                    byte[] aByte = (byte[])reader["fotoperfil"];
                    MemoryStream ms = new MemoryStream(aByte);
                    usuario.FotoPerfil = Image.FromStream(ms);
                }
            }
            Conexion.closeConexion();
            return usuario;
        }

        //Metodo para obtener alumno por id
        public static Alumno porId(int pId)
        {
            //Metodo para registrar por dni si no existe
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT * FROM alumnos WHERE idalumno = @IdAlumno";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@IdAlumno", pId);

            reader = comando.ExecuteReader();

            Alumno usuario = null;

            while (reader.Read())
            {
                usuario = new Alumno();
                usuario.Id = int.Parse(reader["idalumno"].ToString());
                usuario.Password = reader["password"].ToString();
                usuario.Nombre = reader["nombre"].ToString();
                usuario.Apellido = reader["apellido"].ToString();
            }
            Conexion.closeConexion();
            return usuario;
        }

        //Metodo para actualizar datos
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
   
                MySqlCommand comando = new MySqlCommand("UPDATE alumnos SET nombre = @nombre, apellido = @apellido, ci = @ci, fotoperfil = @fotoperfil WHERE idalumno = @idalumno", conexionBD);
                comando.Parameters.AddWithValue("@nombre", pNombre);
                comando.Parameters.AddWithValue("@apellido", pApellido);
                comando.Parameters.AddWithValue("@ci", pDni);
                comando.Parameters.AddWithValue("@fotoperfil", aByte);
                comando.Parameters.AddWithValue("@idalumno", pId);
                int ret = comando.ExecuteNonQuery();
                mensaje = "Se han actualizado correctamente los datos de perfil.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se han podido actualizar los datos de perfil. " + ex.ToString();
            }
        }

        //Metodo para listar alumnos
        public ArrayList ListaAlumnos()
        {
            ArrayList lista = new ArrayList();

            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();
                MySqlDataReader reader;

                string sql = "SELECT * FROM alumnos";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Alumno usuario = null;
                    usuario = new Alumno();
                    usuario.Id = int.Parse(reader["idalumno"].ToString());
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
            catch (MySqlException ex){}


            return lista;
        }

        //Metodo para actualizar password
        public void ActualizarPassword(string pPassword, int pId, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();

                MySqlCommand comando = new MySqlCommand("UPDATE alumnos SET password = @password WHERE idalumno = @idalumno", conexionBD);
                comando.Parameters.AddWithValue("@password", pPassword);
                comando.Parameters.AddWithValue("@idalumno", pId);
                int ret = comando.ExecuteNonQuery();
                mensaje = "Se han actualizado correctamente los datos de perfil.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se han podido actualizar los datos de perfil. " + ex.ToString();
            }
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

                MySqlCommand comando = new MySqlCommand("UPDATE alumnos SET conexion = CURTIME() WHERE idalumno = @idalumno", conexionBD);
                comando.Parameters.AddWithValue("@idalumno", pId);
                int ret = comando.ExecuteNonQuery();
                mensaje = "Se han actualizado correctamente los datos de perfil.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se han podido actualizar los datos de perfil. " + ex.ToString();
            }
        }

        //Metodo para obtener grupo
        public void ObtenerGrupo(int idAlumno, out int idGrupo, out String nombreGrupo)
        {
            idGrupo = 0;
            nombreGrupo = "";

            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT g.idgrupo, g.Nombre FROM grupos g, alumnos_grupo a  where g.idgrupo = a.idgrupo and a.idalumno = @idalumno";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@idalumno", idAlumno);

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                idGrupo = int.Parse(reader["idgrupo"].ToString());
                nombreGrupo = reader["Nombre"].ToString();
            }
            Conexion.closeConexion();
        }

    }
}
