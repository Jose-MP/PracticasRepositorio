using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticasRepositorio.Practicas
{
    public partial class PracticaBaseMySQL : Form
    {
        private string Servidor = "localhost"; 
        private string Basedatos = "ESCOLAR";
        private string UsuarioId = "root"; 
        private string Password = ""; 

        public PracticaBaseMySQL()
        {
            InitializeComponent();
        }

        private void EjecutaComando(string ConsultaSQL)
        {
            try
            {
                string strConn = $"Server={Servidor};Database={Basedatos};User ID={UsuarioId};Password={Password};";
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(ConsultaSQL, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                llenarGrid();
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema");
            }
        }

        private void llenarGrid()
        {
            try
            {
                string strConn = $"Server={Servidor};Database={Basedatos};User ID={UsuarioId};Password={Password};";
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string sqlQuery = "SELECT * FROM Alumnos";
                    MySqlDataAdapter adp = new MySqlDataAdapter(sqlQuery, conn);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "Alumnos");
                    dgvAlumnos.DataSource = ds.Tables[0];
                }
                dgvAlumnos.Refresh();
            }
            catch (MySqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema");
            }
        }

        private void btnCrearBD_Click(object sender, EventArgs e)
        {
            EjecutaComando("CREATE DATABASE ESCOLAR");
        }

        private void btnCreaTabla_Click(object sender, EventArgs e)
        {
            EjecutaComando("CREATE TABLE Alumnos (NoControl VARCHAR(10), nombre VARCHAR(50), carrera INT)");
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNoControl.Text.Trim().Length > 0 &&
                    txtNombre.Text.Trim().Length > 0 &&
                    txtCarrera.Text.Trim().Length > 0)
                {
                    if (int.TryParse(txtCarrera.Text.Trim(), out int carreraValue))
                    {
                        string consultaSQL = $"INSERT INTO Alumnos (NoControl, nombre, carrera) " +
                                             $"VALUES ('{txtNoControl.Text.Trim()}', '{txtNombre.Text.Trim()}', {carreraValue})";

                        EjecutaComando(consultaSQL);
                    }
                    else
                    {
                        MessageBox.Show("El campo 'Carrera' debe ser un número válido.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema: " + Ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e) 
        {
            llenarGrid();
        }
        private void btnBorrar_Click(object sender, EventArgs e) 
        {
            try
            {
                if (dgvAlumnos.SelectedRows.Count > 0)
                {
                    string noControl = dgvAlumnos.SelectedRows[0].Cells["NoControl"].Value.ToString();
                    string consultaSQL = $"DELETE FROM Alumnos WHERE NoControl = '{noControl}'";
                    EjecutaComando(consultaSQL);
                }
                else
                {
                    MessageBox.Show("Seleccione un alumno para eliminar.");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema: " + Ex.Message);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e) 
        {
            try
            {
                string noControlBuscar = txtNoControl.Text.Trim();
                if (!string.IsNullOrEmpty(noControlBuscar))
                {
                    foreach (DataGridViewRow row in dgvAlumnos.Rows)
                    {
                        if (row.Cells["NoControl"].Value != null && row.Cells["NoControl"].Value.ToString() == noControlBuscar)
                        {
                            string nombre = row.Cells["nombre"].Value.ToString();
                            string carrera = row.Cells["carrera"].Value.ToString();
                            MessageBox.Show($"No. Control: {noControlBuscar}\nNombre: {nombre}\nCarrera: {carrera}");
                            return;
                        }
                    }
                    MessageBox.Show("Alumno no encontrado.");
                }
                else
                {
                    MessageBox.Show("Ingrese un número de control.");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema: " + Ex.Message);
            }
        }
    }
}
