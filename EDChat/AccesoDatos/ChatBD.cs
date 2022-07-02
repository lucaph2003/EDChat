using EDChat.Logica;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDChat.AccesoDatos
{
    class ChatBD
    {
        //Metodo para enviar mensajes
        public static void EnviarMensaje(Chat chat, out int codigo, out String mensaje)
        {
            codigo = 1;
            mensaje = "";

            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();

                string sql = "INSERT INTO chat (idremitente, idreceptor, mensaje, fechamensaje, estado) VALUES(@idremitente, @idreceptor, @mensaje, CURTIME(), @estado)";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idremitente", chat.Idremitente);
                comando.Parameters.AddWithValue("@idreceptor", chat.Idreceptor);
                comando.Parameters.AddWithValue("@mensaje", chat.Mensaje);
                comando.Parameters.AddWithValue("@estado", chat.MensajeLeido);
                codigo = comando.ExecuteNonQuery();
                mensaje = "Se han registrado el mensaje correctamente.";

            }
            catch (MySqlException ex)
            {
                codigo = -1;
                mensaje = "No se ha podido registrar el mensaje. " + ex.ToString();
            }
        }

        //Metodo para listar mensajes
        public static ArrayList ListarMensajes(int IdRemitente, int IdReceptor)
        {
            ArrayList lista = new ArrayList();

            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();
                MySqlDataReader reader;

                string sql = "SELECT * FROM chat WHERE idReceptor = @idreceptor and idRemitente = @idremitente or idReceptor = @idremitente and idRemitente = @idreceptor";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@idremitente", IdRemitente);
                comando.Parameters.AddWithValue("@idreceptor", IdReceptor);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Chat chat = null;
                    chat = new Chat();
                    chat.Idchat = int.Parse(reader["idchat"].ToString());
                    chat.Idremitente = int.Parse(reader["idremitente"].ToString());
                    chat.Idreceptor = int.Parse(reader["idreceptor"].ToString());
                    chat.Mensaje = reader["mensaje"].ToString();
                    chat.Fecha = DateTime.Parse(reader["fechamensaje"].ToString());
                    chat.MensajeLeido = bool.Parse(reader["estado"].ToString());
                    lista.Add(chat);
                }

                Conexion.closeConexion();

            }
            catch (MySqlException ex) { }
            return lista;
        }

        //Metodo para actualizar estado de los mensajes
        public static void ActualizarEstado(int pIdchat,int pIdReceptor)
        {
            try
            {
                MySqlConnection conexionBD = Conexion.getConexion();
                conexionBD.Open();

                MySqlCommand comando = new MySqlCommand("UPDATE chat SET estado = true WHERE idchat = @pIdchat AND idReceptor = @pIdReceptor ;", conexionBD);
                comando.Parameters.AddWithValue("@pIdchat", pIdchat);
                comando.Parameters.AddWithValue("@pIdReceptor", pIdReceptor);
                int ret = comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
            }
        }

        

    }
}
