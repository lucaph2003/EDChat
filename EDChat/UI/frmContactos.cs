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

            ArrayList listaContactos = Docente.listaDocentes();
            foreach (Docente doc in listaContactos)
            {
                ListViewItem items = new ListViewItem(doc.nombreususario());
                items.SubItems.Add(doc.apellidoususario());
                items.SubItems.Add(doc.cedula());
                if (doc.Conexion != null) { items.SubItems.Add(doc.conexionUsuario()); }
                listViewContactos.Items.Add(items);
            }
        }



        private void pboBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscar.Text.Length > 0)
            {
                ArrayList listaContactos = Docente.listaDocentes();
                listViewContactos.Items.Clear();
                foreach (Docente doc2 in listaContactos)
                    if (doc2.Nombre.ToUpper().StartsWith(txtBuscar.Text.ToUpper()))
                    {
                        ListViewItem items = new ListViewItem(doc2.nombreususario());
                        items.SubItems.Add(doc2.apellidoususario());
                        items.SubItems.Add(doc2.cedula());
                        if (doc2.Conexion != null) { items.SubItems.Add(doc2.conexionUsuario()); }
                        listViewContactos.Items.Add(items);
                    }
            }
        }
    }
}
