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
using EDChat;

namespace EDChat.UI
{
    public partial class frmInterfaz : Form
    {
        public frmInterfaz()
        {
            InitializeComponent();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            panelContenedor.Refresh();
            AbrirFormhija(new frmAyuda());
        }

        private void AbrirFormhija(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        private void btnChats_Click(object sender, EventArgs e)
        {
            panelContenedor.Refresh();
            AbrirFormhija(new frmChat());
        }

        private void btnAulas_Click(object sender, EventArgs e)
        {
            panelContenedor.Refresh();
            AbrirFormhija(new frmAulas());
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            panelContenedor.Refresh();
            AbrirFormhija(new frmContactos());
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            panelContenedor.Refresh();
            AbrirFormhija(new frmPerfil());
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
