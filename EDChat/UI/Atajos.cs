using System;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using EDChat.Logica;

namespace EDChat.UI
{
    class Atajos
    {
        public static void Cerrar()
        {
            Application.Exit();
            string mensaje;
            int codigo;
            Alumno.actualizarHora(Session.id,out codigo,out mensaje);
        }

        public static void EnterDatos(TextBox x, string dato)
        {
            if (x.Text == dato)
            {
                x.Text = "";
                x.ForeColor = Color.Black;
            }
            if (x.Name == "txtPassword")
            {
                x.UseSystemPasswordChar = true;
            }
            if (x.Name == "txtConPassword")
            {
                x.UseSystemPasswordChar = true;
            }
        }

        public static void LeaveDatos(TextBox x, string dato)
        {
            if (x.Text == "")
            {
                x.Text = dato;
                x.ForeColor = Color.Black;

                if (x.Name == "txtPassword")
                {
                    x.UseSystemPasswordChar = false;
                }
                if (x.Name == "txtConPassword")
                {
                    x.UseSystemPasswordChar = false;
                }
            }
            
        }

    }
}
