using System;
using System.Collections;
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
    public partial class frmContactos : Form
    {
        public frmContactos()
        {
            InitializeComponent();

            ArrayList listaContactos = Alumno.listaAlumnos();
            foreach (Alumno al in listaContactos)
            {
                ListViewItem items = new ListViewItem(al.nombreususario());
                items.SubItems.Add(al.apellidoususario());
                items.SubItems.Add(al.cedula());
                items.SubItems.Add(al.conexionUsuario());
                listViewContactos.Items.Add(items);
            }
        }

        private void listViewContactos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
        }

        private void pboBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
            {
                ArrayList listaContactos = Alumno.listaAlumnos();
                listViewContactos.Items.Clear();
                foreach (Alumno al2 in listaContactos)
                    if (al2.Nombre.ToUpper().StartsWith(txtBuscar.Text.ToUpper()))
                    {
                        ListViewItem items = new ListViewItem(al2.nombreususario());
                        items.SubItems.Add(al2.apellidoususario());
                        items.SubItems.Add(al2.cedula());
                        items.SubItems.Add(al2.conexionUsuario());
                        listViewContactos.Items.Add(items);
                    }
            }
        }
    }
}
