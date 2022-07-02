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

namespace EDChat
{
    public partial class frmChat : Form
    {

        private delegate void DaddItem(String s);


        public frmChat()
        {
            InitializeComponent();
            ArrayList listaAlumnos = Alumno.listaAlumnos();
            foreach (Alumno al in listaAlumnos)
                LstContactos.Items.Add(al);

        }

        private void LstContactos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Alumno al = (Alumno)LstContactos.SelectedItem;
                LstChat.Items.Clear();
                //Llamar a mostrar los mensajes que recibi de este alumno
                ArrayList lista = Chat.listarMensajes(Session.id, al.Id);
                foreach (Chat chat in lista)
                {
                    LstChat.Items.Add(chat);
                    Chat.actualizarEstado(chat.Idchat, Session.id);
                    lblNombreUsuario.Text = al.Nombre  ;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pboBuscar_Click(object sender, EventArgs e)
        {
            ArrayList listaContactos = Alumno.listaAlumnos();
            LstContactos.Items.Clear();
            foreach (Alumno al2 in listaContactos)
                if (al2.Nombre.ToUpper().StartsWith(txtBuscar.Text.ToUpper()))
                {
                    LstContactos.Items.Add(al2);
                }
        }

        private void pboEnviar_Click(object sender, EventArgs e)
        {
            if (txtMensaje.Text.Length > 0)
            {
                if (LstContactos.SelectedItem != null)
                {
                    String nick = Session.nombre;
                    LstChat.Items.Add(nick + ": " + txtMensaje.Text);
                    Alumno al = (Alumno)LstContactos.SelectedItem;

                    String mensaje;
                    int codigo;

                    Chat.enviarMensaje(Session.id, al.Id, txtMensaje.Text, out codigo, out mensaje);

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
            Alumno al = (Alumno)LstContactos.SelectedItem;
            LstChat.Items.Clear();
            lblNombreUsuario.Text = "";

            //Llamar a mostrar los mensajes que recibi de este alumno
            ArrayList lista = Chat.listarMensajes(Session.id, al.Id);
            foreach (Chat chat in lista)
            {
                LstChat.Items.Add(chat);
                Chat.actualizarEstado(chat.Idchat, Session.id);
                lblNombreUsuario.Text = al.Nombre;
            }
        }

        private void frmChat_Load(object sender, EventArgs e)
        {

        }
    }
 }

