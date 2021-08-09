using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDChat.Logica
{
    class Docentes
    {
        //Declaracion de docentes
        int id;
        string nombre, apellido, password, conPassword, dni;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Password { get => password; set => password = value; }
        public string ConPassword { get => conPassword; set => conPassword = value; }
        public string Dni { get => dni; set => dni = value; }
        public int Id { get => id; set => id = value; }
    }
}
