using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDChat.Logica
{
    class Modelo
    {
        public int registrarNuevoUsuario(Alumnos alumnos)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO alumnos (nombre, apellido, password, id_tipo, dni) VALUES(@nombre, @apellido, @password, @id_tipo, @dni)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", alumnos.Nombre);
            comando.Parameters.AddWithValue("@apellido", alumnos.Apellido);
            comando.Parameters.AddWithValue("@password", alumnos.Password);
            comando.Parameters.AddWithValue("@id_tipo", alumnos.Id_tipo);
            comando.Parameters.AddWithValue("@dni", alumnos.Dni);

            int resultado = comando.ExecuteNonQuery();

            return resultado;

        }
        public bool existePassword(string alumnos)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT dni FROM alumnos WHERE password LIKE @password";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@password", alumnos);

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

        public Alumnos porDni(string dniIngresado)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT * FROM alumnos WHERE dni = @dni";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@dni", dniIngresado);

            reader = comando.ExecuteReader();

            Alumnos usuario = null;

            while (reader.Read())
            {
                usuario = new Alumnos();
                usuario.Id = int.Parse(reader["id"].ToString());
                usuario.Password = reader["password"].ToString();
                usuario.Nombre = reader["nombre"].ToString();
                usuario.Apellido = reader["apellido"].ToString();
                usuario.Id_tipo = int.Parse(reader["id_tipo"].ToString());
            }

            conexion.Close();

            return usuario;


        }

        public List<TipoUsuario> GetTipoUsuarios()
        {
            List<TipoUsuario> listadoResultado = new List<TipoUsuario> { };

            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT * FROM tipo_usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                TipoUsuario tipoUsuario = new TipoUsuario();
                tipoUsuario.Id = (int)reader["id"];
                tipoUsuario.Nombre = (String)reader["nombre"];

                listadoResultado.Add(tipoUsuario);
            }

            return listadoResultado;
        }
    }
}
