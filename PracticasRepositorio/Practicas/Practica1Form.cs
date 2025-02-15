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
    public partial class Practica1Form : Form
    {
        public Practica1Form()
        {
            InitializeComponent();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación de Gestión de Contactos, donde el usuario pueda agregar, visualizar y eliminar contactos desde un formulario.");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtTelefono.Text == ""  || txtCorreo.Text == "")
            {
                MessageBox.Show("Faltan datos por llenar, porfavor ingrese lo que se pide");
                return;
            }
            else
            {
                MessageBox.Show("Contacto agregado");
                lbContactos.Items.Add(txtNombre.Text + ", "+ txtTelefono.Text + ", " + txtCorreo.Text);
                
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lbContactos.Items.Count == 0)
            {
                MessageBox.Show("No hay datos para eliminar");
                return;
            }        
            else
            {
                if (lbContactos.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un contacto");
                    return;
                }
                else { 
                MessageBox.Show("Contacto eliminado");
                lbContactos.Items.Remove(lbContactos.SelectedItem);

                }
            }
        }

        private void Practica1Form_Load(object sender, EventArgs e)
        {
            
        }
    }
}
