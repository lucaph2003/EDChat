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
    public partial class frmAyuda : Form
    {
        public frmAyuda()
        {
            InitializeComponent();
        }

        private void lkLblPregunta1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Para enviar un mensaje debemos ingresar al chat que deseemos dentro de la seccion Chats o de la " +
                "seccion Aulas en caso de que queramos hablar con el grupo");
        }

        private void lkLblPregunta2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Para cambiar el nickname debemos entrar en el menu a las seccion de perfil " +
                "asi podemos editarlo desde alli , una vez camb9iado le damos click en aplicar cambios");
        }

        private void lkLblPregunta3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Para Cambiar mi foto de perfil debemos ingresar a la seccion de perfil y debemos " +
                "hacer click sobre la imagen para poder editarla , una vez elegimos la imagen que queremos colocar" +
                " le damos click en aplicar");
        }

       
        private void lnkLabelNotas_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Entramos a la seccion lateral que dice calificaciones , y veremos el nombre de la materia con sus respectivas notas segun su periodo");
        }
    }
}
