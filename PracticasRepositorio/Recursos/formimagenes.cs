using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticasRepositorio
{
    public partial class formimagenes : Form
    {
        public formimagenes()
        {
            InitializeComponent();
            pictureBoxGrande.SizeMode = PictureBoxSizeMode.Zoom;
        }
        public string NombreImagen
        {
            set {nombre.Text = value;}
        }

        private void pictureBoxGrande_Click(object sender, EventArgs e)
        {

        }

        private void nombre_Click(object sender, EventArgs e)
        {

        }
    }
}
