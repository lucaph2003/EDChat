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
    class AsignaturaBD
    {

        //Metodo para Listar asignaturas
        public ArrayList ListarAsignaturas()
        {
            ArrayList lista = new ArrayList();

            try
            {
                MySqlConnection conexion = Conexion.getConexion();
                conexion.Open();
                MySqlDataReader reader;

                string sql = "SELECT * FROM asignatura";
                MySqlCommand comando = new MySqlCommand(sql, conexion);
                reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Asignatura asignatura = null;
                    asignatura = new Asignatura();
                    asignatura.Idasignatura = int.Parse(reader["Idasignatura"].ToString());
                    asignatura.Canthoras = int.Parse(reader["cantidadhoras"].ToString());
                    asignatura.Nombre = reader["nombre"].ToString();
                    lista.Add(asignatura);

                }

                Conexion.closeConexion();

            }
            catch (MySqlException ex) { }

            return lista;
        }
    }
}
