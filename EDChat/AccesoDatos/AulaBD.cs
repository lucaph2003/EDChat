using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDChat.Logica;
using MySql.Data.MySqlClient;

namespace EDChat.AccesoDatos
{
    class AulaBD
    {
        //Metodo para listar mensajes en aulas
        public static ArrayList ListarMensajes(int IdGrupo)
        {
            ArrayList lista = new ArrayList();

            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();
                MySqlDataReader reader;

                string sql = "SELECT * FROM chat_sala WHERE idGrupo = @idgrupo";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idgrupo", IdGrupo);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Aula aula = null;
                    aula = new Aula();
                    aula.Idremitente = int.Parse(reader["idremitente"].ToString());
                    aula.Idgrupo = int.Parse(reader["idgrupo"].ToString());
                    aula.Mensaje = reader["mensaje"].ToString();
                    aula.Fecha = DateTime.Parse(reader["fechamensaje"].ToString());
                    lista.Add(aula);
                }

                Conexion.closeConexion();

            }
            catch (MySqlException ex) { }


            return lista;
        }

        //Metodo para enviar mensajes en aulas
        public static void EnviarMensaje(Aula aula, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";

            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "INSERT INTO chat_sala (idremitente, mensaje, fechamensaje, idgrupo) VALUES(@idremitente, @mensaje, CURTIME(), @idgrupo)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idremitente", aula.Idremitente);
                comando.Parameters.AddWithValue("@mensaje", aula.Mensaje);
                comando.Parameters.AddWithValue("@idgrupo", aula.Idgrupo);
                codigo = comando.ExecuteNonQuery();
                mensaje = "Se han registrado el mensaje correctamente.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se ha podido registrar el mensaje. " + ex.ToString();
            }
        }

    }
}
