using PracticasRepositorio.Practicas;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void practica1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Practica1Form m = new Practica1Form();
            m.MdiParent = this;
            m.Show();
        }

        private void practica2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Practica2Form n = new Practica2Form();
            n.MdiParent = this;
            n.Show();
        }

        private void practica3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Practica3Form o = new Practica3Form();
            o.MdiParent = this;
            o.Show();
        }

        private void practicaBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //o
           //a
           //e
        }

        private void sQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PracticaBaseSQL a = new PracticaBaseSQL();
            a.MdiParent = this;
            a.Show();
        }

        private void mySQLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PracticaBaseMySQL o = new PracticaBaseMySQL();
            o.MdiParent = this;
            o.Show();
        }
    }
}
