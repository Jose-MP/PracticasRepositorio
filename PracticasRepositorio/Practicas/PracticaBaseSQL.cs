using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticasRepositorio.Practicas
{
    public partial class PracticaBaseSQL : Form
    {
        private string Servidor = "JOSERRA\\JOSERRA";
        private string Basedatos = "ESCOLAR";
        private string UsuarioId = "sa";
        private string Password = "010605.jrjrjr";

        private void EjecutaComando(string ConsultaSQL)
        {
            try
            {
                string strConn = $"Server={Servidor};" +
                    $"Database={Basedatos};" +
                    $"User Id={UsuarioId};" +
                    $"Password={Password}";

                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = ConsultaSQL;
                cmd.ExecuteNonQuery();

                llenarGrid();
            }
            catch (SqlException Ex)
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
                string strConn = $"Server={Servidor};" +
                    $"Database={Basedatos};" +
                    $"User Id={UsuarioId};" +
                    $"Password={Password}";

                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                string sqlQuery = "select * from Alumnos";
                SqlDataAdapter adp = new SqlDataAdapter(sqlQuery, conn);

                DataSet ds = new DataSet();
                adp.Fill(ds, "Alumnos");
                dgvAlumnos.DataSource = ds.Tables[0];

                dgvAlumnos.Refresh();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema");
            }
        }
        public PracticaBaseSQL()
        {
            InitializeComponent();
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
                        string consultaSQL = $"INSERT INTO Alumnos (NControl, nombre, carrera) " +
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

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {        
            llenarGrid();
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            llenarGrid();
        }

        private void btnCreaTabla_Click(object sender, EventArgs e)
        {
            EjecutaComando("CREATE TABLE " +
                    "Alumnos (NoControl varchar(10), nombre varchar(50), carrera int)");
        }

        private void btnCrearBD_Click(object sender, EventArgs e)
        {
            try
            {
                string strConn = $"Server={Servidor};" +
                    $"Database=master;" +
                    $"User Id={UsuarioId};" +
                    $"Password={Password}";

                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "CREATE DATABASE ESCOLAR";
                cmd.ExecuteNonQuery();
            }
            catch (SqlException Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Error en el sistema");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chkSQLServer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
