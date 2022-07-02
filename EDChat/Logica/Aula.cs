using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDChat.AccesoDatos;

namespace EDChat.Logica
{
    class Aula
    {
        //Declaracion de atributos de un aula
        string mensaje;
        int idgrupo, idremitente;
        DateTime fecha;

        public int Idgrupo { get => idgrupo; set => idgrupo = value; }
        public int Idremitente { get => idremitente; set => idremitente = value; }
        public string Mensaje { get => mensaje; set => mensaje = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }

        //Metodo puente para enviar mensaje
        public static void enviarMensaje(int pIdgrupo, int pIdRemitente, string pMensaje, out int codigo, out String mensaje)
        {
            Aula aula = new Aula();
            aula.Idgrupo = pIdgrupo;
            aula.Idremitente = pIdRemitente;
            aula.Mensaje = pMensaje;

            AulaBD.EnviarMensaje(aula, out codigo, out mensaje);

        }

        //Metodo puente para listar mensajes
        public static ArrayList listarMensajes(int IdGrupo)
        {
            return AulaBD.ListarMensajes(IdGrupo);
        }
    }
}

