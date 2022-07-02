using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

//En esta clase establecemos la conexion a la base de datos
namespace EDChat.AccesoDatos
{
    class Conexion
    {
        public static string database { get; private set; }

        public static MySqlConnection getConexion()
        {
            //Metodo para obtener la conexion a la base de datos
            string servidor = "192.168.1.16";
            string puerto = "3306";
            string usuario = "lpodesta22";
            string password = "password";
            string bd = "proyecto";

            string cadenaConexion = "server=" + servidor + "; port=" + puerto + "; user id=" + usuario + "; password=" + password + "; database=" + bd;

            MySqlConnection conexion = new MySqlConnection(cadenaConexion);

            return conexion;
        }
        public static void openConexion()
        {
            //Metodo para abrir base de datos
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Open();
        }

        public static void closeConexion()
        {
            //Metodo para cerrar base de datos
            MySqlConnection conexion = Conexion.getConexion();
            conexion.Close();
        }
    }
}
