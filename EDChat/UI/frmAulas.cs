using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;
using System.Net.Sockets;
using System.IO;
using EDChat.Logica;
using System.Collections;

namespace EDChat.UI
{
    public partial class frmAulas : Form
    {

        int idGrupo = 0;
        string nombreGrupo = "";

        public frmAulas()
        {
            InitializeComponent();

            // Obtener grupo
            Alumno.obtenerGrupo(Session.id, out idGrupo, out nombreGrupo);
            lblNombre.Text += " " + nombreGrupo;


            ArrayList lista = Aula.listarMensajes(idGrupo);
            foreach (Aula aula in lista)
            {
                listChat.Items.Add(aula);

            }

        }

        private void pboEnviar_Click(object sender, EventArgs e)
        {
            if (txtMensaje.Text.Length > 0)
            {
                if (idGrupo > 0)
                {
                    String nick = Session.nombre;
                    listChat.Items.Add(nick + ": " + txtMensaje.Text);

                    String mensaje;
                    int codigo;

                    Aula.enviarMensaje(idGrupo, Session.id, txtMensaje.Text, out codigo, out mensaje);

                    if (codigo == 1)
                    {
                        txtMensaje.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Se ha producido el siguiente error: " + codigo.ToString() + "  " + mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El alumno no se encuentra en ningún grupo registrado", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pboActualizar_Click(object sender, EventArgs e)
        {

        }

        private void frmAulas_Load(object sender, EventArgs e)
        {

        }
    }
}
