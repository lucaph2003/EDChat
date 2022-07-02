using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDChat.AccesoDatos;

namespace EDChat.Logica
{
    class Asignatura
    {
        //Declaracion de los atributos de las asignaturas
        int idasignatura, canthoras;
        string nombre;

        public int Idasignatura { get => idasignatura; set => idasignatura = value; }
        public int Canthoras { get => canthoras; set => canthoras = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        //Metodos tostring
        override
        public String ToString()
        {
            return Nombre;
        }

        //Metodo puente del listado de asignaturas
        public static ArrayList listaAsignaturas()
        {
            ArrayList lista = new ArrayList();

            AsignaturaBD asignaturaBD = new AsignaturaBD();

            return asignaturaBD.ListarAsignaturas();
        }

    }
}
