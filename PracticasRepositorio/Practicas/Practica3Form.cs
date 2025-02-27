using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace PracticasRepositorio.Practicas
{
    public partial class Practica3Form : Form
    {
        public Practica3Form()
        {
            InitializeComponent();
        }
        private void txtNumeros_TextChanged(object sender, EventArgs e)
        {
            if (!Class1.inputValidador.EsSoloNumeros(txtNumeros.Text))
            {
                MessageBox.Show("Solo se permiten numeros.");
                txtNumeros.Text = string.Concat(txtNumeros.Text.Where(char.IsDigit));
                txtNumeros.SelectionStart = txtNumeros.Text.Length;
            }
        }

        private void txtLetras_TextChanged(object sender, EventArgs e)
        {
            if (!Class1.inputValidador.EsSoloLetras(txtLetras.Text))
            {
                MessageBox.Show("Solo se permiten letras.");
                txtLetras.Text = string.Concat(txtLetras.Text.Where(char.IsLetter));
                txtLetras.SelectionStart = txtLetras.Text.Length;
            }
        }

        private void btnValidarRFC_Click(object sender, EventArgs e)
        {
            string rfc = txtRFC.Text;
            rfc = Class1.RFCValidador.corregir(rfc);
            txtRFC.Text = rfc;

            if (Class1.RFCValidador.EsRFCValido(rfc))
            {
                MessageBox.Show("RFC valido.");
            }
            else
            {
                MessageBox.Show("RFC invalido.");
            }
        }
    }
}
