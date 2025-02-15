using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticasRepositorio
{
    public partial class Practica2Form : Form
    {
        public Practica2Form()
        {
            InitializeComponent();
        }
        private string[] imagenes;
        private int ImagenActual = 0;
        private void btnElegir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    imagenes = Directory.GetFiles(fbd.SelectedPath, "*.jpg");
                    MessageBox.Show($"Se encontraron {imagenes.Length} imágenes.");
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (imagenes != null && ImagenActual < imagenes.Length)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Image = Image.FromFile(imagenes[ImagenActual]);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Width = 100;
                pictureBox.Height = 100;
                pictureBox.Tag = imagenes[ImagenActual];
                pictureBox.Click += pictureBox1_Click;
                flowLayoutPanel1.Controls.Add(pictureBox);
                ImagenActual++;
            }
            else
            {
                MessageBox.Show("No hay imágenes para agregar");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            ImagenActual = 0;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                string rutaImagen = pictureBox.Tag.ToString();
                string nombreImagen = Path.GetFileName(rutaImagen);

                formimagenes formImagenes = new formimagenes();
                formImagenes.pictureBoxGrande.Image = pictureBox.Image;
                formImagenes.NombreImagen = nombreImagen;
                formImagenes.Text = nombreImagen;
                formImagenes.Show();
            }
        }


        private void Practica2Form_Load(object sender, EventArgs e)
        {

        }
    }
}
