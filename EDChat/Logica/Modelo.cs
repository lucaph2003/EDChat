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
        public int registrarNuevoUsuario(Docentes docentes)
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "INSERT INTO docentes (nombre, apellido, password, dni) VALUES(@nombre, @apellido, @password, @dni)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@nombre", docentes.Nombre);
            comando.Parameters.AddWithValue("@apellido", docentes.Apellido);
            comando.Parameters.AddWithValue("@password", docentes.Password);
            comando.Parameters.AddWithValue("@dni", docentes.Dni);

            int resultado = comando.ExecuteNonQuery();

            return resultado;

        }
        public bool existePassword(string docentes)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT dni FROM docentes WHERE password LIKE @password";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@password", docentes);

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

        public Docentes porDni(string dniIngresado)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();

            string sql = "SELECT * FROM docentes WHERE dni = @dni";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@dni", dniIngresado);

            reader = comando.ExecuteReader();

            Docentes usuario = null;

            while (reader.Read())
            {
                usuario = new Docentes();
                usuario.Id = int.Parse(reader["id"].ToString());
                usuario.Password = reader["password"].ToString();
                usuario.Nombre = reader["nombre"].ToString();
                usuario.Apellido = reader["apellido"].ToString();
            }

            conexion.Close();

            return usuario;


        }
    }
}
