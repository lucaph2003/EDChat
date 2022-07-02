using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDChat.UI
{
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Para enviar un mensaje vamos a la opcion del chat y seleccionamos el chat que queramos , luego le damos a enviar mensaje y actualizamos la pagina" +
                "par que se puedan ver los mensajes enviados");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Esta la seccion de Perfil que esta especialmente creada para la modificacion del usuario a su gusto");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("En la seccion de contactos es especialmente para buscar contactos con un buscador optimizado.");
        }
    }
}
