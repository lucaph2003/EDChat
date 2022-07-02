using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDChat.AccesoDatos;

namespace EDChat.Logica
{
    class Chat
    {
        //Declaracion de los atributos del chat
        int idchat, idremitente, idreceptor;
        string mensaje;
        DateTime fecha;
        bool mensajeLeido;

        public int Idchat { get => idchat; set => idchat = value; }
        public int Idremitente { get => idremitente; set => idremitente = value; }
        public int Idreceptor { get => idreceptor; set => idreceptor = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public bool MensajeLeido { get => mensajeLeido; set => mensajeLeido = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        override
        public String ToString()
        {
            return Docente.porId(Idremitente).Nombre + ": " + Mensaje;
        }

        //Metodo puente para enviar mensaje
        public static void enviarMensaje(int pIdremitente, int pIdreceptor, string pMensaje, out int codigo, out String mensaje)
        {
            Chat chat = new Chat();
            chat.Idremitente = pIdremitente;
            chat.Idreceptor = pIdreceptor;
            chat.Mensaje = pMensaje;
            chat.MensajeLeido = false;

            ChatBD.EnviarMensaje(chat, out codigo, out mensaje);

        }

        //Metodo puente para listar los mensajes
        public static ArrayList listarMensajes(int IdRemitente, int IdReceptor)
        {
            return ChatBD.ListarMensajes(IdRemitente, IdReceptor);
        }
    }
}
