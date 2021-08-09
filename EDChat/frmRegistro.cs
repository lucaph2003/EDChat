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

namespace EDChat
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void txtDni_Enter(object sender, EventArgs e)
        {
            if (txtDni.Text == "DNI")
            {
                txtDni.Text = "";
                txtDni.ForeColor = Color.Black;
            }
        }

        private void txtDni_Leave(object sender, EventArgs e)
        {
            if (txtDni.Text == "")
            {
                txtDni.Text = "DNI";
                txtDni.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Enter(object sender, EventArgs e)
        {
            if (txtNombre.Text == "Nombre")
            {
                txtNombre.Text = "";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                txtNombre.Text = "Nombre";
                txtNombre.ForeColor = Color.Black;
            }
        }

        private void txtApellido_Enter(object sender, EventArgs e)
        {
            if (txtApellido.Text == "Apellido")
            {
                txtApellido.Text = "";
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void txtApellido_Leave(object sender, EventArgs e)
        {
            if (txtApellido.Text == "")
            {
                txtApellido.Text = "Apellido";
                txtApellido.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Contraseña")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Contraseña";
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtConPassword_Enter(object sender, EventArgs e)
        {
            if (txtConPassword.Text == "Confirmar Contraseña")
            {
                txtConPassword.Text = "";
                txtConPassword.ForeColor = Color.Black;
                txtConPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtConPassword_Leave(object sender, EventArgs e)
        {
            if (txtConPassword.Text == "")
            {
                txtConPassword.Text = "Confirmar Contraseña";
                txtConPassword.ForeColor = Color.Black;
                txtConPassword.UseSystemPasswordChar = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Visible = true;
            this.Visible = false;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Docentes nuevoUsuario = new Docentes();
            nuevoUsuario.Nombre = txtNombre.Text;
            nuevoUsuario.Apellido = txtApellido.Text;
            nuevoUsuario.Password = txtPassword.Text;
            nuevoUsuario.ConPassword = txtConPassword.Text;
            nuevoUsuario.Dni = txtDni.Text;

            try
            {

                Logica.Control control = new Logica.Control();
                Modelo modelo = new Modelo();

                //Valido que se hayan cargado todos los datos en el formulario
                string respuesta = control.ctrlRegistro(nuevoUsuario);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Paso validacion y llamo a metodo que guarda el nuevo Usuario
                    int resultado = modelo.registrarNuevoUsuario(nuevoUsuario);

                    //Si resultado es cero hubo algun error
                    if (resultado == 0)
                    {
                        MessageBox.Show(respuesta, "Hubo cagada", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Usuario registrado correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
