using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EDChat.Logica;

namespace EDChat.UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }
        private void txtDni_Enter(object sender, EventArgs e)
        {
            Atajos.EnterDatos(txtDni, "DNI");
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            Atajos.LeaveDatos(txtDni, "DNI");
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            Atajos.EnterDatos(txtPassword, "Contraseña");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Atajos.LeaveDatos(txtPassword, "Contraseña");
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string password = txtPassword.Text;

            try
            {

                Logica.Control ctrl = new Logica.Control();
                string respuesta = ctrl.ctrlLogin(dni, password);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string mensaje;
                    int codigo;
                    Alumno.actualizarHora(Session.id, out codigo, out mensaje);
                    frmInterfaz frm = new frmInterfaz();
                    frm.Visible = true;
                    this.Visible = false;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void lnkRegistrarse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistro frm = new frmRegistro();
            frm.Visible = true;
            this.Visible = false;
        }

        private void pboCerrar_Click(object sender, EventArgs e)
        {
            Atajos.Cerrar();
        }

        private void pboMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
