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
    public partial class frmChats : Form
    {
        private delegate void DaddItem(String s);


        public frmChats()
        {
            InitializeComponent();
            ArrayList listaDocentes = Docente.listaDocentes();
            foreach (Docente doc in listaDocentes)
                listContactos.Items.Add(doc);

        }


        private void btnEnviar_Click(object sender, EventArgs e)
        {
            



        }

        private void LstContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Docente doc = (Docente)listContactos.SelectedItem;
                listChat.Items.Clear();

                //Llamar a mostrar los mensajes que recibi de este docente
                ArrayList lista = Chat.listarMensajes(Session.id, doc.Id);
                foreach (Chat chat in lista)
                {
                    listChat.Items.Add(chat);
                    lblNombre.Text = doc.Nombre;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pboEnviar_Click(object sender, EventArgs e)
        {
            if (txtMensaje.Text.Length > 0)
            {
                if (listContactos.SelectedItem != null)
                {
                    String nick = Session.nombre;
                    listChat.Items.Add(nick + ": " + txtMensaje.Text);
                    Docente doc = (Docente)listContactos.SelectedItem;

                    String mensaje;
                    int codigo;

                    Chat.enviarMensaje(Session.id, doc.Id, txtMensaje.Text, out codigo, out mensaje);

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
                    MessageBox.Show("Debe seleccionar el alumno al que le desea enviar un mensaje", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pboActualizar_Click(object sender, EventArgs e)
        {
            Docente doc = (Docente)listContactos.SelectedItem;
            listChat.Items.Clear();

            //Llamar a mostrar los mensajes que recibi de este docente
            ArrayList lista = Chat.listarMensajes(Session.id, doc.Id);
            foreach (Chat chat in lista)
            {
                listChat.Items.Add(chat);
                lblNombre.Text = doc.Nombre;
            }
        }

        private void pboBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
            {
                ArrayList listaContactos = Docente.listaDocentes();
                listContactos.Items.Clear();
                foreach (Docente doc2 in listaContactos)
                    if (doc2.Nombre.ToUpper().StartsWith(txtBuscar.Text.ToUpper()))
                    {
                        listContactos.Items.Add(doc2);
                    }
            }
        }
    }
}
