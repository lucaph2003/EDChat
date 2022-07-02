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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void txtDni_Enter(object sender, EventArgs e)
        {
            Atajos.EnterDatos(txtDni, "DNI");
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            Atajos.LeaveDatos(txtDni, "DNI");
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            Atajos.EnterDatos(txtNombre, "Nombre");
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            Atajos.LeaveDatos(txtNombre, "Nombre");
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            Atajos.EnterDatos(txtApellido, "Apellido");
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            Atajos.LeaveDatos(txtApellido, "Apellido");
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            Atajos.EnterDatos(txtPassword, "Contraseña");
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Atajos.LeaveDatos(txtPassword, "Contraseña");
        }

        private void txtConPassword_Enter(object sender, EventArgs e)
        {
            Atajos.EnterDatos(txtConPassword, "Confirmar Contraseña");
        }

        private void txtConPassword_Leave(object sender, EventArgs e)
        {
            Atajos.LeaveDatos(txtConPassword, "Confirmar Contraseña");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            String mensaje;
            int codigo;

            
            Alumno.registrar(txtNombre.Text, txtApellido.Text, txtPassword.Text, txtConPassword.Text, txtDni.Text, out codigo, out mensaje);

            if (codigo == 1)
            {
                MessageBox.Show(mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Se ha producido el siguiente error: " + codigo.ToString() + "  " + mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkIniciarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frm = new frmLogin();
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

        private void txtConPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
