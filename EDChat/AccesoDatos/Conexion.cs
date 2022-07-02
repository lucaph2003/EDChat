using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDChat.AccesoDatos
{
    class Conexion
    {
        public static string database { get; private set; }

        //Metodo para Conseguir la conexion a la base de datos
        public static MySqlConnection getConexion()
        {

            string servidor = "192.168.1.16";
            string puerto = "3306";
            string usuario = "lpodesta22";
            string password = "Luca-2003";
            string bd = "proyecto";

            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + password + "; database=" + bd;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;
        }

        //Metodo para Abrir la conexion a la base de datos
        public static void openConexion()
        {
            //Metodo para abrir base de datos
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
        }

        //Metodo para Cerrar la conexion con la base de datos
        public static void closeConexion()
        {
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Close();
        }

        
    }
}
